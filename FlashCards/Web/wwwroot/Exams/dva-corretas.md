ElastiCache speeds up frequent reads by storing data in memory, reducing latency and increasing throughput for read-heavy workloads. It also helps applications that benefit from in-memory caching to avoid repeated computational work.
The correct options (ElastiCache, DynamoDB, and S3) can be used as key/value stores: ElastiCache stores key/value pairs in memory, DynamoDB is a NoSQL key/value database, and S3 objects are accessed by a key.
You must enable the multi-value headers feature on the ALB so that headers with multiple values are delivered to the Lambda function exactly as sent by the client.
Writing to the backend first and then invalidating the cache ensures strong consistency because the database remains the source of truth and the cache is invalidated so subsequent reads get the updated data.
Transferring data over SSL/TLS protects the channel (encryption in transit), and client-side encryption ensures data is encrypted before it leaves the application, satisfying requirements for data in transit.
SSE-KMS provides server-side encryption integrated with AWS KMS and records a key usage audit trail without requiring application changes that would impact performance.
Configuring cross-account IAM roles in the audited accounts and having the application in Account A assume those roles is the most secure approach, because each account retains control and temporary credentials are used.
The supported flow is to upload the deployment bundle to S3 and instruct CodeDeploy to use that artifact for deploying to EC2 instances.
Using encrypted EBS volumes provides at-rest encryption managed by the service without changing the application and with minimal performance impact.
Using CloudFront reduces global latency and offloads traffic from S3 by delivering images via a CDN.
Calling 'GenerateDataKey' returns a plaintext data key and an encrypted copy; using the plaintext data key to encrypt the object locally before upload ensures the content is encrypted in transit and at rest.
Configuring a CORS policy on the cdfonts bucket allows resources hosted on another domain to be loaded by the browser, resolving font blocking caused by same-origin policies.
'sam build' and 'sam deploy' are the standard workflow to build SAM artifacts and deploy the updated application to AWS.
'Rolling with additional batch' adds temporary instances to maintain capacity during deployment, preventing visible capacity reduction while using the existing instances.
The instance metadata endpoint (169.254.169.254) provides the public IP address programmatically and reliably.
Enabling cache only when required for development and test avoids continuous provisioned cache costs while keeping production appropriately configured.
Directing read queries to read replicas offloads the primary database and improves read performance for read-heavy workloads.
An event-driven architecture processes data as it arrives using events and services that support near-real-time processing instead of nightly batches.
Implementing exponential backoff reduces request collisions with provisioned throughput, and switching to on-demand mode lets the table scale automatically to handle spikes.
SSE-KMS offers KMS-managed keys with additional control and auditing while offloading key management to AWS, meeting regulatory needs without fully managing keys in-house.
After resharding there are 6 shards; each shard can be processed by one worker, so the maximum number of instances needed to process all shards is equal to the shard count (6).
Amazon Cognito provides synchronization features for user data across devices without requiring a full backend, enabling preferences and user data sync.
The correct options describe supported methods to create an application version (zip and upload via console or create via CLI) and then update the Elastic Beanstalk environment.
Caching the file in '/tmp' allows reusing the file between invocations within the same Lambda container and reduces repeated downloads, improving performance.
Creating a GSI with a minimal set of projected attributes returns only the required data for queries and reduces RCU consumption while improving performance.
Creating a mapping template transforms query string parameters into the JSON payload or format expected by the Lambda handler.
Creating an IAM user per developer gives each person unique credentials and auditability while keeping the approach simple and secure for local development.
Strongly consistent reads consume more RCUs than eventually consistent reads because they require immediate confirmation of the latest data.
Uploading and deploying a new application version via the Elastic Beanstalk console is the supported flow for updating an application.
Option A includes conditions that allow the action only when the user is authenticated via web identity and enforces the correct condition to limit updates to the 'user_name' attribute.
The canary deployment strategy using aliases and shifting 10% of traffic allows a gradual rollout and quick rollback with minimal user impact if errors occur.
Deploying each component in its own Elastic Beanstalk environment allows independent scaling according to each component's needs.
Change sets show the differences and the impact of changes before applying an update to the stack.
Using Lambda aliases and versions lets the API Gateway point to an alias and you can update the alias to point to a new version without changing the gateway endpoint.
A bucket policy that explicitly denies requests where 'SecureTransport' is false enforces that only HTTPS/TLS requests are accepted by the bucket.
ELB+EC2 and API Gateway+Lambda are valid architectures for providing a real-time REST endpoint, either with managed servers or serverless functions.
The '/tmp' directory is the local temporary storage available to Lambda functions and is appropriate for small files that are used during execution and do not need persistence.
Using ElastiCache with a cache-aside strategy allows the application to read from cache when available and update the cache when needed, reducing database load and page latency.
Elastic Beanstalk with Auto Scaling lets the company offload infrastructure management, scaling, and deployments to the platform while focusing on website development.
The Lambda context object contains a request ID for the invocation; writing logs to the console lets CloudWatch capture them and associate logs with that request ID.
The EC2 role must be permitted to assume the AccessPII role, and the application should call 'AssumeRole' to obtain temporary credentials that allow access to the PII table in the other account.
Enabling AWS X-Ray tracing for the Lambda function provides distributed traces that show the time spent in DynamoDB API calls and helps identify bottlenecks.
Creating a read replica and directing read traffic to it isolates read load from write activity on the primary, eliminating the write-induced slowdown for readers.
'TransactWriteItems' provides atomic, all-or-nothing writes across multiple items in DynamoDB.
Use 'PutMetricData' with the EC2 instance launched with an IAM role that grants the necessary permissions so the instance can securely send metrics without embedded credentials.
The SQS Extended Client Library stores large payloads in S3 and places a reference in the SQS message, which is the recommended approach for very large messages.
Publishing a custom CloudWatch metric via 'PutMetricData' lets the team visualize the thread count over time in CloudWatch dashboards.
Reducing package size and moving RDS connection initialization outside the handler reduce cold start time and avoid recreating connections on each invocation, improving latency without extra cost.
Publishing a custom CloudWatch metric for API errors and using SNS for notifications allows creating alarms and delivering alerts to subscribers (email, SMS, etc.).
Adding an approval action in a pipeline stage is the native CodePipeline mechanism to require human approval before progressing to deployment.
Redis in ElastiCache Cluster Mode provides a managed, highly available in-memory cache that supports clustering and replication, making it suitable for cached content that is costly to regenerate while maximizing uptime.
The most likely cause is that the Lambda function needs more memory because processing large images is memory and CPU intensive; increasing memory also increases CPU and can reduce execution time to complete the processing within Lambda limits.
Enabling server-side encryption in Kinesis Streams ensures data at rest is encrypted using AWS KMS keys, protecting stored records while they remain in the stream for long retention periods.
Amazon Cognito supports federated authentication including SAML 2.0, provides user sign-up and sign-in features, and scales without significant operational overhead, making it cost-effective for mobile apps.
Using a custom CloudWatch metric allows the application to publish the number of concurrent users, which Auto Scaling can consume to make scaling decisions tailored to the actual user count.
The Serverless Application Model (SAM) extends CloudFormation with serverless resource types and supports automated packaging, deployment, and easy rollbacks, which fits the need for automation plus rollback capability.
Restricting access based on primary key values in IAM policies or application logic enforces per-user access control at the item level, ensuring users can only access their own data.
Amazon Cognito supports unauthenticated (guest) identities alongside authenticated users, allowing limited access without full sign-in while integrating with identity providers for authenticated flows.
The 'aws cloudformation package' command uploads local artifacts like Lambda code to S3 and outputs a transformed template that references the S3 locations, which is required before running 'aws cloudformation deploy'.
Breaking the logic into multiple smaller Lambda functions reduces package size, fits within Lambda limits, and improves maintainability and deployment reliability compared to trying to circumvent size limits.
Persistent session state for serverless functions belongs in an external durable store like DynamoDB, which provides low-latency access and durability across invocations.
Implementing exponential backoff for retries reduces immediate retry storms and is a best practice to handle transient ProvisionedThroughputExceeded errors, allowing requests to succeed when capacity becomes available.
Rolling with additional batch keeps full capacity during updates by provisioning an extra batch during deployment while avoiding the higher cost of creating a full immutable environment, thus meeting both capacity and cost constraints.
Instantiating clients outside the handler enables connection reuse across invocations in the same execution environment, reducing latency and cold-start overhead by avoiding repeated client initialization.
AWS Step Functions provides a managed workflow orchestration service with state management, retries, and visual debugging, making it suitable to replace fragile custom state machine code.
Defining distinct IAM roles for each ECS task and referencing them in task definitions follows the principle of least privilege and allows containers to run with specific permissions regardless of the underlying EC2 instance role, while supporting bin packing.
AWS Step Functions can manage long-running workflows, execute tasks in parallel, provide durable state, and handle retries and waits, which makes it ideal for a process that can span days.
Using DynamoDB Time To Live (TTL) with a numeric timestamp attribute automatically and cost-effectively removes items after 48 hours without extra compute or scanning, which is ideal for high-volume ephemeral data.
Implementing retries with exponential backoff is the recommended first response to transient throttling errors, reducing immediate retry storms and allowing the service to recover.
Amazon Kinesis Streams supports high-throughput ingestion with ordered shards and multiple consumers that can read in parallel, making it suitable and cost-effective for real-time processing at scale.
CodeDeploy expects 'appspec.yml' at the root of the application bundle so it can find the deployment hooks and file mappings when executing a deployment.
Kinesis Firehose is a managed service designed for high-throughput ingestion and continuous delivery to destinations like S3, providing buffering, scaling, and format conversion with minimal management.
Using Lambda Layers to provide external libraries reduces deployment package size and cold-start time for functions by separating shared dependencies, improving compute efficiency across multiple functions.
Parallel scans with a limited read rate allow the scan to complete faster by distributing reads across segments while controlling throughput to avoid impacting normal workloads.
Using CloudFront caches content at edge locations to handle high request rates and randomizing key prefixes helps distribute load across S3 partitions, both improving request performance at scale.
API Gateway mapping templates can transform JSON requests into the XML format expected by a SOAP backend, allowing a RESTful front-end to interact with a SOAP service transparently.
SSE-KMS requires calling KMS for envelope key operations, and the KMS API limits (request rate) can become the bottleneck when uploading massive numbers of objects, causing added latency.
A Rolling deployment updates instances in batches using existing instances, minimizing outage while preserving instance-level artifacts like local logs because it does not replace all instances at once.
Kinesis preserves order within each shard (FIFO per shard), so records are processed in the order they arrived for a given shard, but there is no ordering guarantee across multiple shards.
A bucket policy that denies uploads missing the 'x-amz-server-side-encryption' header enforces encryption at upload time and prevents unencrypted objects from being stored in the bucket.
Using a unique MessageGroupId per sender on an SQS FIFO queue ensures that messages from each sender are processed in order while allowing parallel processing of different groups.
Amazon Cognito provides user sign-in, sign-up, and profile management with support for multiple platforms and persistent user preferences, making it well-suited for application authentication across devices.
Environment variables allow a single Lambda function package to reference different resource endpoints and configuration per deployment environment, enabling reuse across dev/test/prod without code changes.
Creating a cross-account IAM role and using STS AssumeRole grants short-lived credentials with scoped permissions and is the recommended secure method for temporary cross-account access.
To capture traces from an EC2-hosted application, you must instrument the application with the X-Ray SDK and run the X-Ray daemon as a local process to buffer and send trace data to the X-Ray service.
Assigning an IAM role to instances via the Auto Scaling launch configuration provides temporary credentials and follows AWS best practices for secure authentication when calling CloudWatch PutMetricData.
A unique attribute like 'reviewID' provides a high-cardinality partition key which evenly distributes items across partitions, yielding the most consistent performance for a very large dataset.
Using IAM policy conditions (for example with condition keys like 'aws:username' or 's3:prefix') can generalize the policy so it enforces per-user access control without creating separate policies per user.
Server-side encryption with AWS KMS (SSE-KMS) allows AWS-managed encryption while using a customer-managed KMS key, giving control over the master key and supporting auditing and access control.
Performing a dry-run (where supported) can validate permissions without executing the action, and using the IAM policy simulator verifies that a role policy allows the required Kinesis actions, making these two practical verification steps.
Storing code in CodeCommit, using CodePipeline to run unit tests, and SNS for notifications provides an integrated CI workflow with publish/subscribe notifications for failures.
Calling ChangeMessageVisibility to extend the visibility timeout ensures the processing instance retains exclusive access while it works, and then DeleteMessage removes it when done, preventing duplicate processing.
Amazon Cognito supports MFA for user authentication flows and provides user management and secure delivery of verification codes, making it suitable for application-level MFA.
Eventually consistent reads consume half the read capacity of strongly consistent reads for the same item size, so 5 RCUs of eventually consistent reads yield more effective throughput than the equivalent strongly consistent option.
Enabling server access logging that writes logs to the same bucket can cause a feedback loop where each upload generates logs which generate more logs, rapidly increasing storage usage.
Assigning an IAM role to the ECS task (task role) provides temporary, managed credentials scoped to the task's permissions and is the recommended secure method for ECS applications to access AWS services.
Reviewing the CodeBuild build logs for the failed phase provides direct error output and context to diagnose compilation failures, which is the most efficient first step.
For in-place CodeDeploy deployments, the typical hook sequence is to stop the application, run BeforeInstall, AfterInstall tasks, and then start the application, which matches the correct option ordering.
The 'decode-authorization-message' API in AWS STS decodes encoded authorization messages from AWS so they can be inspected in a human-readable form, which is the appropriate action for this error.
AWS Systems Manager Parameter Store (especially with the SecureString type backed by KMS) provides an easy, managed way to store and retrieve secrets with minimal administration and integration with EC2 IAM roles.
Start by checking AWS CloudTrail for a 'DeleteBucket' event because CloudTrail records API calls that change AWS resources and will show who or what deleted the bucket.
The recommended approach is to run 'aws configure' to store the developer's access key and secret in the CLI configuration so commands run with that IAM identity.
Lambda automatically scales out by running multiple concurrent executions to handle increased event traffic, allowing many image-resize tasks to run in parallel.
Using DynamoDB Accelerator (DAX) provides an in-memory cache that reduces read latency to microseconds and lowers the need to over-provision read capacity for spiky workloads.
If the Lambda execution role lacks permissions to create log groups or put log events, then no logs will be written to CloudWatch even though the function runs, so ensuring the role has CloudWatch Logs permissions fixes this.
Two common causes are a missing X-Ray daemon on the EC2 host and an instance role lacking 'xray:PutTraceSegments' and 'xray:PutTelemetryRecords' permissions, both preventing trace data from being sent to or accepted by X-Ray.
Developer-authenticated identities in Amazon Cognito let you assign stable, unique identifiers to users across devices while integrating with your own authentication system and issuing credentials as needed.
The standard CLI workflow is to run 'aws cloudformation package' to upload local artifacts and produce a modified template, then 'aws cloudformation deploy' to create or update the stack.
The likely cause is that long-lived access keys stored in environment variables are still being used by the CLI; using a managed policy on the role is not the issue—existing credentials override instance role credentials until rotated or removed.
S3 provides eventual consistency for overwrite PUTs and deletes, so an immediate read after overwrite can sometimes return the previous version until replication completes.
Best practice is to call 'GenerateDataKey' to obtain a unique data key for each file, use that key to encrypt the file locally, and store the encrypted data key alongside the ciphertext for later decryption via KMS.
Configuring a Dead Letter Queue (DLQ) for asynchronous Lambda invocations captures failed events in SQS for later inspection and debugging after retries are exhausted.
Usage plans in API Gateway let you define throttling and quota limits and associate API keys with developers, making it straightforward to offer different request packages with minimal management.
AWS Step Functions state machines provide durable orchestration for sequencing and parallel execution of Lambda functions and are the appropriate tool to implement the described flow.
Amazon Aurora (MySQL) supports traditional ACID transactions, and DynamoDB supports transactional operations via the Transact* APIs, so both can implement all-or-nothing multi-item updates.
Cloning the repository with the Git CLI inside the Lambda execution, committing the new file, and pushing the change replicates the normal Git workflow and is a straightforward way to add files to CodeCommit.
Instance profile credentials (IAM roles attached to EC2) provide temporary, automatically rotated credentials and are the recommended secure method for EC2-based applications.
Use Amazon Cognito to issue temporary credentials for authenticated and unauthenticated users, and use role assumption via STS for fine-grained access control; both approaches scale and avoid embedding static credentials.
Federating the SAML directory through a Cognito identity pool allows users to authenticate via SAML without mirroring identities on AWS, and using the 'cognito-identity.amazonaws.com:sub' condition lets you grant per-user access to resources.
Before deploying with SAM CLI, you must package the application (sam package or sam build/deploy) so local artifacts are prepared and uploaded to S3 for deployment.
Server-side encryption with customer-provided keys (SSE-C) lets you provide your own encryption keys from on-premises while S3 handles the encryption and storage, matching the requirement.
Publishing S3 events to SQS decouples uploads from processing and smooths spikes, letting the queue buffer work and Lambda scale consumers at a rate the backend can handle.
In ECS, including both containers in the same task definition and mounting a shared volume allows containers in the same task to share logs and metrics efficiently.
A CloudWatch alarm on the EC2 instance metric is the native and reliable way to monitor CPU utilization and send SNS notifications when thresholds are exceeded.
AWS Secrets Manager stores and automatically rotates database credentials securely and integrates with RDS and EC2, making it the best choice for secret management and rotation.
Creating a new environment with the updated version and performing a URL swap achieves a near-zero-downtime cutover and allows easy rollback by swapping back to the previous environment.
Generating a presigned S3 URL with a 15-minute expiration allows authenticated users to securely download a specific object for a limited time without changing bucket policies.
Using a 'Catch' with a 'ResultPath' allows you to attach the error details to the state output while preserving the original input, enabling better debugging and error inspection.
The error indicates throttling from excessive API calls; implementing exponential backoff reduces request frequency during spikes and is the recommended way to handle throttling.
Exporting the bucket name in the Outputs and using ImportValue in other stacks is the supported and efficient CloudFormation mechanism for sharing resources across stacks.
The 'AfterInstall' hook runs on instances after the application files are in place, making it the right time to change file permissions before the application starts.
DynamoDB Accelerator (DAX) is an in-memory cache for DynamoDB that can significantly reduce read latency and improve overall application performance.
Both the AWS CLI CloudFormation package/deploy commands and the SAM-specific package/deploy commands are valid ways to package and deploy SAM templates; using either approach automates artifact upload and stack deployment.
Creating a Cognito user pool and enabling MFA in that user pool provides managed user authentication with multi-factor capabilities suitable for mobile apps.
Enabling task IAM roles and assigning per-task roles provides least-privilege access so each microservice gets only the permissions it needs regardless of the EC2 instance role.
Instrumenting the code to emit traces to AWS X-Ray and analyzing them in the X-Ray console helps locate latency hotspots and visualize where time is spent inside the Lambda function.
Increasing the long polling timeout reduces empty ReceiveMessage API calls and lowers request charges when message frequency is low, making SQS usage more cost efficient.
Enabling X-Ray on API Gateway and Lambda provides distributed tracing that shows end-to-end request timing and exposes bottlenecks across services.
When multiple credential sources exist, the AWS SDK uses a credential chain and the explicit IAM role deny will take precedence, so the instance will be denied S3 actions despite the stored keys.
Setting Retention to 'Retain source bundle in S3' tells Elastic Beanstalk to keep the uploaded source bundles in the S3 bucket even when the lifecycle policy removes application version records.
If the cache is not invalidated or updated when the underlying price changes, the application will continue to serve stale data from ElastiCache, causing the observed inconsistency.
For HTTPS access to CodeCommit, you should configure the Git credential helper (AWS CLI credential helper) to use an AWS credential profile so Git can authenticate using IAM credentials.
To enable X-Ray tracing for Lambda, grant the function an execution role with X-Ray permissions and enable tracing in the function configuration so the platform can send traces.
To let developers launch instances with an instance role, create a role trusted by EC2 with DynamoDB permissions and grant developers the iam:PassRole permission so they can assign that role to instances during launch.
Packaging the function with its dependencies in a zip and uploading it ensures Lambda has the required modules available in the execution environment, resolving import errors.
Use a Cognito identity pool to exchange user pool JWTs for temporary AWS credentials, enabling browser-based access to DynamoDB without embedding long-lived keys in the client.
AWS CloudFormation expresses infrastructure as templates that can be versioned and deployed repeatedly, and pairing with CodeCommit enables code-based staging and rollbacks.
Environment variables for containers are specified in the task definition's 'environment' parameter so the container receives them at start time when the task runs.
Storing metadata in DynamoDB keyed by 'Customer ID' with 'TS-Server' as the sort key enables efficient range queries for a user's objects within a time range.
Global Secondary Indexes provide alternative query keys and can be tailored to include the needed attributes, enabling efficient queries and lower read latency for frequently accessed attributes.
The correct option uses S3 event notifications to trigger Lambda directly, providing low latency and minimal cost because Lambda only runs when objects arrive and S3 pushes the event.
API Gateway resource policies can restrict access to callers from a specific AWS account or VPC by evaluating the caller's principal and account, making them the most secure way to limit access to a particular account.
Amazon DocumentDB offers MongoDB-compatible APIs and reduces the amount of application change required while providing a managed service that runs on AWS.
Adding logging statements in the Lambda code ensures errors are written to CloudWatch Logs automatically, providing administrators with direct, searchable error information for troubleshooting.
Enabling 'ConsistentRead=true' on GetItem requests requests strongly consistent reads from DynamoDB so the caller gets the latest committed value rather than eventually-consistent data.
Amazon Kinesis Data Streams ingests high-throughput streaming data and can trigger Lambda consumers to process records, making it a serverless, scalable approach for stream processing.
Deploying ElastiCache for Redis provides a managed in-memory cache that can store frequently read historical data, reducing load on RDS and improving read performance with minimal management.
For 10 KB items, each strongly consistent read costs 2 RCUs (each 4 KB chunk uses 2 RCUs), so 10 reads require 20 RCUs; transactional writes cost 2 WCUs per write times additional overhead—choosing read 30 and write 40 provides safe provisioned capacity with headroom.
Using ElastiCache (Redis) provides a low-latency, shared session store suitable for containerized services on Fargate, giving users consistent session state regardless of which container handles their requests.
Adding read replicas (Redis replication or cluster mode) spreads read traffic across nodes and improves resiliency by providing failover options, addressing both load and availability concerns.
AWS X-Ray provides distributed tracing to visualize service maps and trace latencies across microservices, helping isolate the component or segment causing performance issues.
Adding a unit test phase to the CodeBuild 'buildspec' integrates tests into the CI/CD pipeline stage that builds artifacts, enabling automated test runs before deployment.
Amazon DynamoDB is a scalable key-value store that supports large datasets and eventual consistency with low-latency reads suitable for many-terabyte growth and variable item sizes.
Cognito identity pools support unauthenticated identities, allowing guest users to obtain temporary credentials and access S3 with restricted permissions without creating user accounts.
AWS CodeCommit is a managed Git repository service that provides version control, branching, and collaborative workflows suited for long-term source code storage and review.
The ReceiveMessage API supports a 'MaxNumberOfMessages' parameter (up to 10) that allows the consumer to retrieve multiple messages in a single call, increasing processing throughput.
When using ALB with Lambda targets, you must grant permission for the ALB to invoke the function (via lambda:AddPermission). Missing invoke permissions prevent the ALB from calling the Lambda.
Usage plans let you define per-customer throttling and quota limits and associate API keys with users, enabling the company to enforce individual SLAs for request rate and usage.
Exporting the VPC's output in the infrastructure stack and using 'Fn::ImportValue' in the application stack is the CloudFormation-native way to reference resources across stacks.
Cognito identity pools provide federation support for multiple identity providers (including SAML and social providers like Facebook) and can issue temporary AWS credentials for service access with minimal custom coding.
The correct CLI command to publish custom metric data to CloudWatch is 'put-metric-data'; without publishing metric data, alarms cannot be created based on those metrics.
Publishing each generated value as a custom CloudWatch metric lets the developer visualize and monitor the data over time through CloudWatch dashboards without accessing the instance.
CodePipeline supports a built-in manual approval action that can send notifications (for example via SNS) and pause execution until an approver accepts, providing a controlled human approval step.
To create a REST GET endpoint for a serverless app, define an API Gateway API and configure a GET method that integrates with the Lambda function to handle requests.
Storing the connection string as a secret in AWS Secrets Manager allows secure storage, easy rotation, and retrieval at runtime without changing the Lambda code.
Server access logging records detailed request logs for S3 and moving logs to Glacier after 90 days via lifecycle policies balances audit retention needs and cost savings for long-term storage.
SSE-KMS uses AWS KMS to manage customer master keys (CMKs) with fine-grained IAM controls, rotation, and key disabling features that meet the requirement for key lifecycle management.
Storing uploads in S3 makes them instantly available to all instances and is the scalable, durable approach for shared file storage in an Auto Scaling environment.
Enabling CORS on the API Gateway method ensures the API includes the proper 'Access-Control-Allow-Origin' header in responses, allowing browser clients from the static site to make cross-origin requests.
Client-side encryption with a KMS-managed CMK allows the Security team to manage keys while ensuring data is encrypted before transmission to S3, satisfying the requirement that encryption happens client-side and keys are controlled by security.
Increasing the number of shards increases capacity for reads and writes on the stream, and implementing exponential backoff reduces immediate retry pressure; together they address throttling errors effectively.
The correct approach is to call 'aws logs associate-kms-key' (or use the console equivalent) to associate a KMS CMK ARN with an existing CloudWatch Logs log group so future log events are encrypted.
Assigning an IAM role to EC2 instances with a least-privilege read-only policy is secure and avoids embedding long-lived credentials in code, enabling automatic credential rotation.
Externalizing sessions to a shared store like ElastiCache ensures session continuity across deployments and instances, preventing users from being logged out or losing session state during blue/green cutovers.
Configuring S3 event notifications to trigger a Lambda function that performs the DynamoDB insert is event-driven, low-latency, and cost-effective for reacting to new objects.
For in-place deployments, automatic rollback triggers a fresh deployment of the last known good application version (creating a new deployment record) to restore service to the previous state.
Updating the assets bucket policy to permit requests originating from the static site (or the site's origin) allows cross-bucket access securely without opening the bucket publicly.
You can configure notifications or event triggers for CodePipeline from the CodePipeline console to invoke a Lambda function when pipeline state changes occur, making the direct integration straightforward.
The SAM workflow builds local artifacts, packages them (uploading to S3), and then deploys the packaged template from S3, which is the standard SAM deployment sequence.
Attaching an IAM instance role to the EC2 instance grants temporary credentials and follows security best practices without hardcoding or storing static credentials on the instance.
CodePipeline can be triggered by changes in S3 or commits to CodeCommit; both provide immediate, event-driven triggers for automated build and deployment.
Moving processing to EC2 instances in an Auto Scaling group that poll SQS provides scalable, long-running processing for messages that exceed Lambda's execution limits, making it the most scalable approach.
Increasing Lambda memory also increases CPU allocation proportionally, which speeds up CPU-bound Node.js processing without changing the runtime or code.
Rolling back the Lambda function to the previous version quickly restores the previous working code and is the fastest way to recover from a faulty release.
Both Amazon DynamoDB and ElastiCache provide shared storage for session state: DynamoDB offers durable storage while ElastiCache provides low-latency in-memory session storage for fast access.
Installing and configuring the CloudWatch agent on-premises allows logs and metrics to be sent securely to CloudWatch for centralized monitoring, using appropriate IAM credentials.
Cognito user pools provide managed user authentication with tokens that expire and can be refreshed, and integrating a Cognito authorizer with API Gateway enforces authenticated access to resources.
Reducing package size minimizes cold start initialization work, and increasing memory can reduce cold start latency since it often increases CPU resources, both helping to shorten cold starts.
VPC Flow Logs capture IP traffic information for network interfaces in the VPC and can be used to verify whether packets are reaching resources in subnet B.
When a bucket uses SSE-KMS, the caller needs permission to use the KMS key for envelope key operations such as 'kms:GenerateDataKey'; granting this permission to the IAM user resolves the access denied error for PutObject.
Use the Amazon Cognito hosted UI and customize it with your company logo because the hosted UI supports branding and is the supported way to present a login page managed by Cognito.
The combination of GetItem, UpdateItem and PutItem allows the function to read an item, update attributes when present, and create the item if needed, covering both read and write operations.
SSE-KMS meets the audit requirement because AWS KMS provides key usage logs and audit trails via AWS CloudTrail, showing when and by whom the CMK was used.
Storing static content in S3 and serving it through a CloudFront distribution reduces latency globally by offloading static assets to an object store and caching them at edge locations.
Storing the S3 object key and using a VPC endpoint for S3 lets private, secure access to objects from within the VPC without making objects public, which is a scalable long-term solution.
Increasing the function's memory allocation also increases the available CPU, so allocating the maximum memory will minimize average runtime for CPU-bound workloads.
The straightforward change is to update the application's database connection string to point to the new RDS endpoint and credentials so the app uses RDS for storage.
A target tracking scaling policy that uses queue depth or a related metric can automatically scale the number of consumers to keep message backlog within targets while controlling costs.
Amazon Cognito user pools provide user management, sign-up/sign-in, and federation with social identity providers, which matches the requirements.
A Lambda authorizer can validate incoming headers by querying DynamoDB and return an IAM policy to API Gateway, enabling custom header-based authentication.
The GetSessionToken API returns temporary credentials when MFA is required; clients use it to obtain session credentials that include MFA authentication.
KMS has request rate limits; contacting AWS Support to increase KMS limits and adding retries with exponential backoff will mitigate throttling and transient failures.
Publishing processed data to an Amazon SNS topic allows administrators to receive notifications via multiple delivery protocols (email, SMS, etc.) and is suitable for alerting.
AWS KMS supports automatic key rotation for customer-managed CMKs, which is the simplest built-in way to ensure keys are rotated annually.
Using API Gateway stages and stage variables gives unique endpoints for different versions and supports testing and configuration separation in a standard way.
Generating a data key with GenerateDataKey and using the plaintext data key locally to encrypt large objects is the recommended envelope encryption approach for large data.
To access CodeCommit over HTTPS you create Git credentials generated via IAM for users, which allow HTTPS Git operations against CodeCommit.
'BatchGetItem' is the DynamoDB API operation designed to retrieve multiple items in a single request.
A NAT instance must have source/destination checks disabled so it can forward traffic for other instances; disabling this attribute allows NAT functionality.
Historically, the US-Standard region exhibited eventual consistency for read-after-write for some operations, meaning an immediate read might not yet see the object.
The option reflects the (exam-style) stated limit of 1,000,000 buckets per account in this dataset.
To avoid storing credentials on the instance you create an IAM role with appropriate DynamoDB permissions and launch the EC2 instance with that role so applications can assume the role.
IAM policy logic defaults to deny, and explicit allows override that default deny; however explicit denies take precedence over explicit allows.
If the instance lacks a public IP or Elastic IP, assigning an Elastic IP will make it reachable from the Internet using a public address.
The default visibility timeout for SQS messages is 30 seconds, during which the message is hidden from other consumers after retrieval.
SNS structured notification payloads are typically JSON objects that include fields like MessageId, Subject, Message, and unsubscribe URL where applicable.
The 'x-amz-server-side-encryption' header tells S3 to apply server-side encryption (such as AES256 or aws:kms) when storing the object.
Elastic Beanstalk supports common platforms such as Apache Tomcat and .NET, providing managed deployments for these environments.
Using Fn::GetAtt to retrieve the 'DNSName' attribute and joining it with the protocol returns the load balancer's URL in CloudFormation templates.
Bucket policies and ACLs are S3-native mechanisms to control access to buckets and objects.
By default CloudFormation rolls back and deletes resources created during a failed stack creation, terminating the process to leave no partial stack.
SNS Publish requests commonly include TopicArn, Message, and optionally Subject; these are valid parameters to publish a notification.
The instance metadata service provides the instance's public and private IP addresses via HTTP endpoints accessible from within the instance.
AMIs are region-specific; a public AMI is usable within the region where it is stored unless copied to other regions.
The EC2 API call 'DescribeImages' returns a list of AMIs and their attributes.
Customers are responsible for IAM credential lifecycle, security group and ACL configuration, EBS encryption decisions, and OS patch management as part of the shared responsibility model.
Reducing the page size limits the amount of read throughput consumed per scan request, spreading load over time and reducing impact on provisioned capacity.
Using an encrypted file system or enabling EBS encryption ensures data at rest on the volume is protected.
Many AWS SDKs default to 'us-east-1' if no region is explicitly configured, which is the typical default region in examples.
SWF ensures tasks are assigned once without duplication, supports long-running workflow executions (up to a year), and uses deciders and workers to manage workflows.
Re-resolving DNS can avoid clients reusing a single ELB node, and using globally-distributed test clients ensures traffic comes from multiple network paths and IPs to exercise all backends.
SNS supports delivery to HTTP endpoints and SMS among other transports like email and SQS.
Storing images in S3 and adding a pointer in DynamoDB keeps the table lightweight and minimizes provisioned throughput consumption.
AWS Support can raise soft limits such as the number of tables per account and provisioned throughput limits.
Increasing the visibility timeout before processing gives the consumer time to complete work, and deleting the message afterwards ensures it is removed only after successful processing.
Generating a pre-signed URL for each authorized download provides temporary, secure access to private S3 objects only to paid subscribers.
A hash key with high cardinality like User ID distributes requests across partitions and helps provisioned throughput efficiency.
Using the office identifier as the hash key and name as the range key enables efficient queries confined to an office and filtered by name range, minimizing throughput usage.
EBS-backed instances support stop/start operations because their root volume persists as an EBS volume, unlike instance-store backed instances.
Auto Scaling and CloudFormation are management services provided as part of the AWS platform that do not incur separate service charges beyond the resources they manage.
Using the S3 multipart upload API allows you to upload objects larger than the single PUT limit (5 GB) by splitting the file into parts and assembling them on the server, which is the appropriate solution for a 6 GB file.
Elastic Beanstalk can provision and manage resources such as Auto Scaling groups, Elastic Load Balancers, and RDS instances as part of an environment to simplify deployment and scaling of applications.
Requesting temporary security credentials via web identity federation (for example using Cognito or STS with Facebook tokens) is secure because it avoids embedding long-lived credentials in the app and limits permissions and lifetime.
AWS provides official SDKs for many languages, including PHP and Java, which are maintained by AWS to access AWS services.
600 writes per minute is approximately 10 writes per second; each write is 1 KB which consumes 1 write capacity unit, so about 10 WCU are required.
4xx HTTP response codes indicate client errors (bad request, unauthorized, not found, etc.) and mean there was a problem with the request sent to DynamoDB.
Setting 'ReceiveMessageWaitTimeSeconds' enables long polling, which reduces empty responses by allowing the receive call to wait up to the specified time for messages instead of returning immediately.
The S3 website endpoint for the Tokyo region (ap-northeast-1) uses the format 'myawsbucket.s3-website-ap-northeast-1.amazonaws.com', which is the correct region-specific website endpoint.
Creating and deleting tables on an hourly basis allows you to remove large sets of items efficiently by deleting the table, saving on storage and avoiding many individual delete operations.
Externalizing session state to a shared cache like ElastiCache ensures session data is available to all instances behind the load balancer and prevents users from being logged out when requests are routed to different servers.
Removing public read access and using signed, time-limited URLs ensures only authorized requests can access your objects, preventing hotlinking and unauthorized use.
DynamoDB uses optimistic concurrency control and supports conditional writes to help prevent conflicting updates and maintain consistency without using pessimistic locks.
The 'CreatePlatformEndpoint' API is used to register device tokens (endpoints) with SNS programmatically, which is the recommended way to register and manage device endpoints for push notifications.
Throttling can occur due to a hot partition caused by a heavily used partition key (hash key); even if the table's aggregate capacity is available, a single partition can exceed its allocated throughput.
Using a prefix that varies by instance (for example starting with 'instanceID_...') helps distribute object keys across S3 partitions and avoids hotspots, improving performance for many parallel writers.
Standard SQS delivers messages at-least-once (one or more times) and does not guarantee ordering; FIFO queues provide ordering and deduplication but are a different queue type.
Two valid approaches are: authenticate against LDAP and then assume an IAM role via STS mapped to the user, or implement an identity broker that authenticates against LDAP and requests federated credentials from STS to provide scoped access to S3.
You must upload 'welcome.html' to the bucket and set the bucket's Website Hosting Index Document to 'welcome.html' so it will be served as the root page.
Amazon S3 server-side encryption uses the Advanced Encryption Standard (AES), commonly AES-256, as the block cipher for encrypting objects.
Add annotations to segments in X-Ray; annotations are indexed and let you filter and query traces efficiently, so adding them in code and segment documents enables the desired indexing.
In the Elastic Beanstalk console you can change the environment configuration to select a new load balancer type and then deploy a new version; updating the configuration and redeploying is the straightforward approach.
AWS CodeCommit is a managed source control service (Git) that supports commits across multiple files, branching and version history for collaborative development.
AWS CodeDeploy supports automated deployments to EC2 instances and on-premises servers, making it the appropriate service for this requirement.
To support 50 requests/sec with 100s average execution, the required concurrency may exceed the account's default limit; you must request a concurrency limit increase from AWS Support before deployment.
Using ElastiCache (Memcached) provides in-memory session storage with very low latency, which is ideal for externalizing session state while keeping the web tier stateless and meeting performance requirements.
Updates to the primary table must also be written to the GSI; if the GSI's write capacity is underprovisioned, writes to the primary table can be throttled even while the table's own WCU appear available.
Conditional writes allow you to specify a condition (for example only update if the current value matches an expected value) which prevents accidental overwrites in concurrent update scenarios.
You must configure an event source mapping between the DynamoDB stream and the Lambda function so that stream records trigger Lambda invocations.
High-resolution CloudWatch metrics allow publishing at sub-minute intervals (as low as 1 second); publishing every 5 seconds gives the granularity needed to base scaling on the last 15 seconds of activity.
Amazon Kinesis Data Streams is designed for real-time ingestion of large volumes of streaming data from many producers and provides low-latency processing suitable for fraud detection and live dashboards.
The least-privilege approach is to add the specific actions 'codecommit:CreateBranch' and 'codecommit:DeleteBranch' which are exactly what is required to create and delete branches.
AWS Systems Manager Parameter Store (with SecureString parameters) can store secrets and AWS KMS can be used to encrypt them; together they provide secure storage and encryption for rotated credentials used by Lambda.
'appspec.yml' is the file used by CodeDeploy to define deployment actions and hooks; updating it (or ensuring it is present and correct) is required for CodeDeploy to apply the deployment.
The recommended pattern is to call 'GenerateDataKey' to receive both the plaintext data encryption key (for local encryption) and the encrypted data key for storage; this enables client-side encryption of large objects without sending plaintext to KMS.
'IntegrationLatency' measures the time taken by the backend integration (for example, Lambda) to respond to API Gateway, and 'Latency' measures the total client-perceived latency; both help diagnose timeouts.
CloudFront with signed URLs in front of S3 provides global low-latency delivery and controlled access to downloads at low cost, making it an efficient choice for firmware distribution.
Implementing exponential backoff for retries is the recommended approach to handle DynamoDB throttling errors, reducing retry pressure and allowing operations to succeed as capacity becomes available.
Amazon ElastiCache (Redis or Memcached) offers in-memory session storage with low latency and options for replication and high availability, making it well-suited for session state in scalable applications.
The AWS Serverless Application Model (SAM) provides a simplified syntax for declaring serverless resources (API Gateway, Lambda, DynamoDB) in CloudFormation templates.
Moving session state to a scalable managed store like DynamoDB and using an ELB with an Auto Scaling group for the web tier are effective refactors to increase elasticity.
AWS X-Ray provides distributed tracing that helps correlate calls across components, identify latencies and errors, and pinpoint root causes in production systems.
CloudWatch metric filters start producing metrics only for log events that occur after the filter is created; they do not retroactively create metrics for past log entries.
The 'Transform' section must be present in the template root to indicate the SAM transform, which enables the use of SAM shorthand resources.
Amazon ElastiCache provides an in-memory cache (Redis or Memcached) which reduces latency and database load for frequently-read data.
Setting a reserved concurrency limit on the second Lambda function prevents it from consuming the entire account concurrency pool and ensures capacity remains for other functions.
ElastiCache for Redis provides in-memory session storage with options for replication and high availability, making sessions fault tolerant and reducing downtime.
Files inside '.ebextensions' must have a '.config' extension to be processed by Elastic Beanstalk; renaming 'healthcheckurl.yaml' to 'healthcheckurl.config' will allow the settings to be applied.
Increasing the memory allocation for a Lambda function also increases the proportionate CPU available to the function, which can improve compute performance.
Caching user data in ElastiCache reduces database read latency, and making database calls asynchronous allows the application to continue processing without blocking while waiting for the DB response.
Cognito Sync (or the equivalent data sync features) allows synchronizing user profile data across devices associated with an identity without requiring a custom backend, enabling updates to be propagated to all devices.
After creating an API key, the key must be associated with a usage plan and the API stage by calling 'createUsagePlanKey', which binds the API key to the usage plan that is attached to the API stage and allows requests to be authorized.
Amazon Cognito with web identity federation lets users sign in using Amazon, Facebook, Google, and other social identity providers and exchange those tokens for temporary AWS credentials to access S3 securely.
Installing the CloudWatch Logs agent on the EC2 instance allows the application log files to be sent to CloudWatch Logs where administrators can view, search, and create metrics or alarms.
Creating a fresh table for the batch load and deleting the table afterward is the most efficient approach when the data is transient, because deleting the table removes all items instantly and avoids millions of delete operations.
If the Lambda function fails during processing, the service may retry the invocation, which produces duplicate log entries with the same original request ID when the retry succeeds or logs again.
Amazon API Gateway provides a single front-door for multiple backend services, enabling unified routing, throttling, authentication, and monitoring for many consumers and simplifying the architecture.
Hosting static website files in S3 and distributing them globally with CloudFront is the standard serverless pattern for static websites with low cost and high performance.
Creating custom metrics in a dedicated namespace with unique metric names for each application allows you to plot them together on a single CloudWatch dashboard for easy monitoring.
Cognito user pools manage user directories, authentication, and self-service password reset, and can be combined with identity pools to grant temporary AWS credentials for access to AWS resources.
AWS Data Pipeline can be used to orchestrate and schedule a series of data-processing tasks across environments, though for application deployments a CI/CD toolchain would usually be preferred.
Adding a random suffix (or otherwise salting) to the partition key distributes writes across more partitions and prevents a hot partition during spikes, which can be a low-cost fix.
Amazon ElastiCache provides a managed in-memory store with replication and persistence options that can be used to accumulate results with low latency while minimizing inconsistency during scaling.
Elastic Beanstalk multi-container Docker environments use ECS task definitions to describe the containers, ports, and resource requirements for container instances.
Using an EC2 instance profile (IAM role attached to the instance) provides temporary credentials to the applications running on the instance without hardcoding credentials and with minimal management overhead.
Publishing a custom CloudWatch metric for callbacks and using CloudWatch alarms is cost-effective and provides rolling statistics, retention, and automated alerting without building additional infrastructure.
Immutable deployments create a separate set of instances with the new version and switch traffic only after they are healthy, enabling safe rollbacks and minimizing downtime if an update fails.
Placing ElastiCache in front of the database for frequently-read items reduces database load and latency and is an efficient way to handle read spikes.
A strongly consistent read of a 7KB item consumes 2 read capacity units (because reads >4KB round up), so 3 reads/s require 6 RCUs. Writes of 7KB consume 1 WCU per write rounded up to the 1 KB increment multiplied accordingly; 10 writes/s would require provisioning the equivalent (commonly calculated to 70 WCU in this option's context).
If a Lambda function errors while processing Kinesis records, Lambda will retry processing those records which can result in duplicates; proper error handling or checkpointing is required to avoid repeated processing.
AWS Systems Manager Parameter Store SecureString provides encrypted secret storage with rotation support and allows the application to retrieve secrets at runtime without code changes when secrets rotate.
Calling 'update-function-code' points Lambda to the new S3 object or updates the function's code directly, which is the least disruptive way to instruct Lambda to use the new deployment package.
Associating the Lambda function with the VPC private subnets lets it access RDS in the VPC, and adding a NAT Gateway provides outbound internet access from those private subnets so the function can reach public endpoints.
When CloudFormation manages function code via S3, you must update the stack with the new S3Key or S3ObjectVersion so CloudFormation updates the Lambda resource to point to the new package.
For ECS, run the X-Ray daemon as a sidecar container (or Docker image), instrument your application code to emit trace segments, and assign an IAM role to the ECS task so the daemon can send trace data to X-Ray.
Enabling S3 default encryption ensures objects are encrypted at rest using the chosen encryption method (SSE-S3, SSE-KMS, etc.) and satisfies data-at-rest encryption requirements.
The 'Mappings' section in CloudFormation allows you to provide region-specific values (such as AMI IDs) and look them up in the template so the correct AMI is used per region.
Performing a Query on the GSI with eventually-consistent reads consumes the least RCU for the targeted set of items because Query restricts reads to matching keys and eventual consistency halves the RCU cost compared to strong consistency.
Creating an invalidation for the changed objects forces CloudFront edge caches to fetch the updated content from the origin so users see the new version.
You can include inline code in the CloudFormation template (for small functions) or reference a ZIP file in S3 from an 'AWS::Lambda::Function' resource to deploy the function via CloudFormation.
Bundling custom libraries with your function code into the deployment ZIP ensures the runtime has the dependencies available at invocation time and is the recommended method.
Terminating SSL at the ELB by configuring SSL certificates on the load balancer offloads the CPU-intensive TLS work from the EC2 instances and secures traffic.
Packaging the function code together with all required native and language libraries in the deployment ZIP ensures dependencies are available to the Lambda runtime at execution time.
Storing session state in DynamoDB provides a highly available, durable, and scalable backend so sessions are preserved even if individual EC2 instances fail.
DynamoDB Streams captures item-level changes and can be consumed to propagate updates to other services or databases in near-real time, providing a decoupled and reliable replication mechanism.
AWS CodeCommit is a managed Git service that supports distributed version control where developers can work offline and synchronize changes peer-to-peer when connected.
Creating a CloudWatch Events (EventBridge) scheduled rule is a serverless way to trigger a Lambda function on a cron or fixed-rate schedule, such as every 10 minutes.
Creating a GSI with 'sport_name' as the partition key and 'score' as the sort key allows efficient queries for top performers per sport without scanning the entire table.
Amazon Cognito supports unauthenticated identities via identity pools, allowing anonymous users to receive temporary, limited-privilege AWS credentials without requiring login.
Granting decryption permissions via an S3 bucket policy and ensuring the EC2 instance IAM role has KMS permissions allows the EC2 application to access SSE-KMS encrypted objects; both S3 policies and IAM role permissions are commonly used together to enable access.
A delay queue causes messages to become visible to consumers only after a configurable delay period after they are sent, effectively hiding new messages temporarily.
Using CodeCommit gives distributed developers a managed Git repository with efficient incremental transfers and integrates with deployment pipelines to Elastic Beanstalk, minimizing upload time and administrative overhead.
Amazon DynamoDB Accelerator (DAX) is an in-memory caching service designed specifically for DynamoDB to speed up repeated read requests with microsecond latency.
Client-side encryption with KMS-managed keys ensures sensitive data is encrypted before transmission and stored in S3 in encrypted form, while KMS and client-side logging can ensure access auditability and protect data end-to-end.
The STS response includes the temporary credentials tied to the IAM principal (the Access Key ID shown), so the permissions used are those associated with that IAM principal.
Using pagination for CLI list calls retrieves results in smaller chunks and prevents timeouts when listing large numbers of resources.
Port mappings for containers are defined in the ECS task definition which describes how container ports map to host ports and how networking should be configured.
Amazon DynamoDB provides single-digit millisecond latency for key-value lookups, making it an appropriate choice for indexing metadata that must be retrieved quickly.
Amazon CloudWatch Logs is the service designed to collect and securely store application logs from EC2 instances and other resources in a centralized place for monitoring and analysis.
Using the Kinesis Producer Library can optimize batching and aggregation of records on the producer side, improving throughput and helping streams accommodate high peak rates.
Breaking a large template into nested stacks for common patterns increases maintainability and reuse and is a recommended CloudFormation best practice.
Implementing exponential backoff in the application reduces the rate of retry attempts when throttling or rate limits are encountered and is the recommended pattern for handling 'LimitExceeded' errors from AWS services.
Enabling DynamoDB Time To Live (TTL) on an attribute containing the expiration timestamp automatically removes expired items without custom code or additional infrastructure.
Using asynchronous (Event) Lambda invocations allows the processing of many files in parallel without waiting for each invocation to return, which is the fastest approach when individual results are not needed synchronously.
The S3 multipart upload API lets you upload large objects in parts and is the supported method for uploading objects larger than the single PUT limit, enabling a 15 GB upload.
Developers must first run the AWS CLI command that returns Docker login credentials (e.g., the output of 'aws ecr get-login' or the modern 'aws ecr get-login-password' piped into 'docker login') and then run 'docker pull REPOSITORY_URI:TAG' to pull the image.
Amazon Cognito user pools provide a scalable user directory, sign-up and sign-in flows, and user attribute storage suitable for millions of users.
Granting the Lambda function an execution role with the specific S3 permissions it needs follows least-privilege and is the secure best practice for giving the function access to the bucket.
To encrypt traffic end-to-end, configure CloudFront's Viewer Protocol Policy to require HTTPS from clients and set the Origin Protocol Policy to 'HTTPS Only' so CloudFront communicates with the origin over TLS.
A strongly consistent read of a 5 KB item consumes 2 read capacity units (RCU) because reads are calculated per 4 KB chunk; for 100 reads/sec you need 100 * 2 = 200 RCUs.
Lambda function logs are sent to Amazon CloudWatch Logs by default, so the Developer should look in CloudWatch to examine function error logs and execution traces.
Lambda provides ephemeral disk space at '/tmp' (typically 512 MB or configurable) for temporary files during execution; using '/tmp' is the most efficient approach for transient storage.
AWS Elastic Beanstalk provides a managed platform for running web applications on Tomcat without needing to manage underlying infrastructure, making it the easiest deployment option for this scenario.
Amazon ElastiCache is a shared, in-memory store that provides low-latency access to session data across multiple instances, making it ideal for session storage behind a load balancer.
Amazon SQS (queues) and Amazon SNS (pub/sub) provide managed asynchronous messaging patterns that help microservices communicate without tight coupling and without degrading performance.
Best practices are to delete root user access keys and to rely on IAM roles instead of long-lived access keys wherever possible to reduce risk and management overhead.
Assigning an IAM role to the EC2 instance (instance profile) provides temporary credentials to make AWS API calls securely without embedding static credentials.
ALBs add an 'X-Forwarded-For' header containing the original client IP; modifying the application to read this header preserves horizontal scalability while obtaining client IPs.
To separate the RDS instance from an Elastic Beanstalk-managed environment, the recommended approach is to create a new environment without RDS and migrate the application to use an externally managed RDS instance.
Common reasons why CodeDeploy did not run include pushing the change to a non-master branch (so the pipeline wasn't triggered) or a failure in an earlier pipeline stage that prevented deployment from continuing.
Cognito's push synchronization feature allows updates to be pushed to devices silently when appropriate permissions and IAM roles are configured, enabling seamless sync notifications.
Running the traditional LAMP stack on EC2 with a managed relational backend like Amazon Aurora (MySQL-compatible) provides a direct and flexible way to host the application on AWS.
Long polling with a shorter wait interval reduces empty responses and allows the consumer to receive messages as soon as they arrive, minimizing the delay between message arrival and dashboard update.
Moving both shared images and cache data to S3 centralizes storage and allows multiple horizontally scaled instances to access the same data without relying on local disks.
Enabling DynamoDB Streams and configuring an event source mapping so Lambda is invoked directly from the stream is the standard way to trigger functions on item lifecycle events.
The most common cause of 'command not found' is that the 'aws' executable is not on the system PATH, so the shell cannot locate the CLI program.
Using SQS with an Auto Scaling group that scales based on queue depth lets you elastically provision workers to handle long-running fraud checks and cope with peak order rates without over-provisioning.
Storing configuration and secrets in Systems Manager Parameter Store and retrieving them at build time reduces the size of inlined environment variables and is the recommended approach for large or sensitive values.
API Gateway honors cache-control headers from clients; by passing 'Cache-Control: max-age=0' in the request, clients can force cache revalidation/expiration for their requests.
Using S3 Event Notifications to trigger a Lambda that updates DynamoDB provides near-real-time updates and is cost-effective because it is serverless and reacts only to object changes.
AWS Serverless Application Model (SAM) supports inline or referenced Swagger/OpenAPI definitions for API Gateway resources, enabling consistent, repeatable deployments of serverless APIs.
Adding an S3 event notification that triggers a new Lambda function to generate thumbnails decouples thumbnail work from upload processing and ensures uploads are not delayed while minimizing changes to existing code.
Deploying a new API stage (for example 'v2') in API Gateway and exposing its URL lets existing clients continue using 'v1' while others migrate to 'v2', providing a safe migration path.
Amazon Cognito user pools can federate OpenID providers and issue JWTs, and using a custom authorizer in API Gateway lets you implement a custom authorization model securely and simply.
Elastic Beanstalk configuration files with the '.config' extension must be placed in the '.ebextensions' folder at the root of the application source bundle to be processed.
Reusing a database connection across invocations by placing it in the function's global scope reduces connection setup overhead and improves performance for frequently-invoked Lambda functions.
Browsers enforce same-origin policies; if JavaScript in one bucket tries to access resources in another bucket, the target bucket must have CORS configured to allow those requests.
Adding random prefixes to key name prefixes (for example adding random hex to folder names) distributes writes across S3's internal partitions and helps avoid hot spots when handling very high PUT rates.
