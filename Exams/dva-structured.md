# DVA-C02 Guide (Version 1.3)

## Content Domain 1 — Development with AWS Services

### Task 1 — Develop code for applications hosted on AWS

**Knowledge of:**
- Architectural patterns (for example, event-driven, microservices, monolithic, choreography, orchestration, fanout)
- Idempotency
- Differences between stateful and stateless concepts
- Differences between tightly coupled and loosely coupled components
- Fault-tolerant design patterns (for example, retries with exponential backoff and jitter, dead-letter queues)
- Differences between synchronous and asynchronous patterns
  - CORRECT: A Lambda authorizer can validate incoming headers by querying DynamoDB and return an IAM policy to API Gateway, enabling custom header-based authentication.
  - CORRECT: The GetSessionToken API returns temporary credentials when MFA is required; clients use it to obtain session credentials that include MFA authentication.
  - CORRECT: KMS has request rate limits; contacting AWS Support to increase KMS limits and adding retries with exponential backoff will mitigate throttling and transient failures.
  - CORRECT: Publishing processed data to an Amazon SNS topic allows administrators to receive notifications via multiple delivery protocols (email, SMS, etc.) and is suitable for alerting.
  - CORRECT: AWS KMS supports automatic key rotation for customer-managed CMKs, which is the simplest built-in way to ensure keys are rotated annually.
  - CORRECT: Using API Gateway stages and stage variables gives unique endpoints for different versions and supports testing and configuration separation in a standard way.
  - CORRECT: Generating a data key with GenerateDataKey and using the plaintext data key locally to encrypt large objects is the recommended envelope encryption approach for large data.
  - CORRECT: To access CodeCommit over HTTPS you create Git credentials generated via IAM for users, which allow HTTPS Git operations against CodeCommit.
  - CORRECT: 'BatchGetItem' is the DynamoDB API operation designed to retrieve multiple items in a single request.
  - CORRECT: A NAT instance must have source/destination checks disabled so it can forward traffic for other instances; disabling this attribute allows NAT functionality.
  - CORRECT: Historically, the US-Standard region exhibited eventual consistency for read-after-write for some operations, meaning an immediate read might not yet see the object.
  - CORRECT: The option reflects the (exam-style) stated limit of 1,000,000 buckets per account in this dataset.
  - CORRECT: To avoid storing credentials on the instance you create an IAM role with appropriate DynamoDB permissions and launch the EC2 instance with that role so applications can assume the role.
  - CORRECT: IAM policy logic defaults to deny, and explicit allows override that default deny; however explicit denies take precedence over explicit allows.
  - CORRECT: If the instance lacks a public IP or Elastic IP, assigning an Elastic IP will make it reachable from the Internet using a public address.
  - CORRECT: The default visibility timeout for SQS messages is 30 seconds, during which the message is hidden from other consumers after retrieval.
  - CORRECT: SNS structured notification payloads are typically JSON objects that include fields like MessageId, Subject, Message, and unsubscribe URL where applicable.
  - CORRECT: The 'x-amz-server-side-encryption' header tells S3 to apply server-side encryption (such as AES256 or aws:kms) when storing the object.
  - CORRECT: Elastic Beanstalk supports common platforms such as Apache Tomcat and .NET, providing managed deployments for these environments.
  - CORRECT: Using Fn::GetAtt to retrieve the 'DNSName' attribute and joining it with the protocol returns the load balancer's URL in CloudFormation templates.
  - CORRECT: Bucket policies and ACLs are S3-native mechanisms to control access to buckets and objects.
  - CORRECT: By default CloudFormation rolls back and deletes resources created during a failed stack creation, terminating the process to leave no partial stack.
  - CORRECT: SNS Publish requests commonly include TopicArn, Message, and optionally Subject; these are valid parameters to publish a notification.
  - CORRECT: The instance metadata service provides the instance's public and private IP addresses via HTTP endpoints accessible from within the instance.
  - CORRECT: AMIs are region-specific; a public AMI is usable within the region where it is stored unless copied to other regions.
  - CORRECT: The EC2 API call 'DescribeImages' returns a list of AMIs and their attributes.
  - CORRECT: Customers are responsible for IAM credential lifecycle, security group and ACL configuration, EBS encryption decisions, and OS patch management as part of the shared responsibility model.
  - CORRECT: Reducing the page size limits the amount of read throughput consumed per scan request, spreading load over time and reducing impact on provisioned capacity.
  - CORRECT: Using an encrypted file system or enabling EBS encryption ensures data at rest on the volume is protected.
  - CORRECT: Many AWS SDKs default to 'us-east-1' if no region is explicitly configured, which is the typical default region in examples.
  - CORRECT: SWF ensures tasks are assigned once without duplication, supports long-running workflow executions (up to a year), and uses deciders and workers to manage workflows.
  - CORRECT: Re-resolving DNS can avoid clients reusing a single ELB node, and using globally-distributed test clients ensures traffic comes from multiple network paths and IPs to exercise all backends.
  - CORRECT: SNS supports delivery to HTTP endpoints and SMS among other transports like email and SQS.
  - CORRECT: Storing images in S3 and adding a pointer in DynamoDB keeps the table lightweight and minimizes provisioned throughput consumption.
  - CORRECT: AWS Support can raise soft limits such as the number of tables per account and provisioned throughput limits.
  - CORRECT: Increasing the visibility timeout before processing gives the consumer time to complete work, and deleting the message afterwards ensures it is removed only after successful processing.
  - CORRECT: Generating a pre-signed URL for each authorized download provides temporary, secure access to private S3 objects only to paid subscribers.
  - CORRECT: A hash key with high cardinality like User ID distributes requests across partitions and helps provisioned throughput efficiency.
  - CORRECT: Using the office identifier as the hash key and name as the range key enables efficient queries confined to an office and filtered by name range, minimizing throughput usage.
  - CORRECT: EBS-backed instances support stop/start operations because their root volume persists as an EBS volume, unlike instance-store backed instances.
  - CORRECT: Auto Scaling and CloudFormation are management services provided as part of the AWS platform that do not incur separate service charges beyond the resources they manage.
  - CORRECT: Using the S3 multipart upload API allows you to upload objects larger than the single PUT limit (5 GB) by splitting the file into parts and assembling them on the server, which is the appropriate solution for a 6 GB file.
  - CORRECT: Elastic Beanstalk can provision and manage resources such as Auto Scaling groups, Elastic Load Balancers, and RDS instances as part of an environment to simplify deployment and scaling of applications.
  - CORRECT: Requesting temporary security credentials via web identity federation (for example using Cognito or STS with Facebook tokens) is secure because it avoids embedding long-lived credentials in the app and limits permissions and lifetime.
  - CORRECT: AWS provides official SDKs for many languages, including PHP and Java, which are maintained by AWS to access AWS services.
  - CORRECT: 600 writes per minute is approximately 10 writes per second; each write is 1 KB which consumes 1 write capacity unit, so about 10 WCU are required.
  - CORRECT: 4xx HTTP response codes indicate client errors (bad request, unauthorized, not found, etc.) and mean there was a problem with the request sent to DynamoDB.
  - CORRECT: Setting 'ReceiveMessageWaitTimeSeconds' enables long polling, which reduces empty responses by allowing the receive call to wait up to the specified time for messages instead of returning immediately.
  - CORRECT: The S3 website endpoint for the Tokyo region (ap-northeast-1) uses the format 'myawsbucket.s3-website-ap-northeast-1.amazonaws.com', which is the correct region-specific website endpoint.
  - CORRECT: Creating and deleting tables on an hourly basis allows you to remove large sets of items efficiently by deleting the table, saving on storage and avoiding many individual delete operations.
  - CORRECT: Externalizing session state to a shared cache like ElastiCache ensures session data is available to all instances behind the load balancer and prevents users from being logged out when requests are routed to different servers.
  - CORRECT: Removing public read access and using signed, time-limited URLs ensures only authorized requests can access your objects, preventing hotlinking and unauthorized use.
  - CORRECT: DynamoDB uses optimistic concurrency control and supports conditional writes to help prevent conflicting updates and maintain consistency without using pessimistic locks.
  - CORRECT: The 'CreatePlatformEndpoint' API is used to register device tokens (endpoints) with SNS programmatically, which is the recommended way to register and manage device endpoints for push notifications.
  - CORRECT: Throttling can occur due to a hot partition caused by a heavily used partition key (hash key); even if the table's aggregate capacity is available, a single partition can exceed its allocated throughput.
  - CORRECT: Using a prefix that varies by instance (for example starting with 'instanceID_...') helps distribute object keys across S3 partitions and avoids hotspots, improving performance for many parallel writers.
  - CORRECT: Standard SQS delivers messages at-least-once (one or more times) and does not guarantee ordering; FIFO queues provide ordering and deduplication but are a different queue type.
  - CORRECT: Two valid approaches are: authenticate against LDAP and then assume an IAM role via STS mapped to the user, or implement an identity broker that authenticates against LDAP and requests federated credentials from STS to provide scoped access to S3.
  - CORRECT: You must upload 'welcome.html' to the bucket and set the bucket's Website Hosting Index Document to 'welcome.html' so it will be served as the root page.
  - CORRECT: Amazon S3 server-side encryption uses the Advanced Encryption Standard (AES), commonly AES-256, as the block cipher for encrypting objects.
  - CORRECT: In the Elastic Beanstalk console you can change the environment configuration to select a new load balancer type and then deploy a new version; updating the configuration and redeploying is the straightforward approach.
  - CORRECT: AWS CodeCommit is a managed source control service (Git) that supports commits across multiple files, branching and version history for collaborative development.
  - CORRECT: AWS CodeDeploy supports automated deployments to EC2 instances and on-premises servers, making it the appropriate service for this requirement.
  - CORRECT: To support 50 requests/sec with 100s average execution, the required concurrency may exceed the account's default limit; you must request a concurrency limit increase from AWS Support before deployment.
  - CORRECT: Using ElastiCache (Memcached) provides in-memory session storage with very low latency, which is ideal for externalizing session state while keeping the web tier stateless and meeting performance requirements.

**Skills in:**
- Creating fault-tolerant and resilient applications in uma linguagem de programação
- Creating, extending, and maintaining APIs
- Writing and running unit tests in development environments
- Writing code to use messaging services
- Writing code that interacts with AWS services by using APIs and AWS SDKs
- Handling data streaming by using AWS services
    - CORRECT: Updates to the primary table must also be written to the GSI; if the GSI's write capacity is underprovisioned, writes to the primary table can be throttled even while the table's own WCU appear available.
    - CORRECT: Conditional writes allow you to specify a condition (for example only update if the current value matches an expected value) which prevents accidental overwrites in concurrent update scenarios.
    - CORRECT: You must configure an event source mapping between the DynamoDB stream and the Lambda function so that stream records trigger Lambda invocations.
    - CORRECT: High-resolution CloudWatch metrics allow publishing at sub-minute intervals (as low as 1 second); publishing every 5 seconds gives the granularity needed to base scaling on the last 15 seconds of activity.
    - CORRECT: Amazon Kinesis Data Streams is designed for real-time ingestion of large volumes of streaming data from many producers and provides low-latency processing suitable for fraud detection and live dashboards.
    - CORRECT: The least-privilege approach is to add the specific actions 'codecommit:CreateBranch' and 'codecommit:DeleteBranch' which are exactly what is required to create and delete branches.
    - CORRECT: AWS Systems Manager Parameter Store (with SecureString parameters) can store secrets and AWS KMS can be used to encrypt them; together they provide secure storage and encryption for rotated credentials used by Lambda.
    - CORRECT: 'appspec.yml' is the file used by CodeDeploy to define deployment actions and hooks; updating it (or ensuring it is present and correct) is required for CodeDeploy to apply the deployment.
    - CORRECT: The recommended pattern is to call 'GenerateDataKey' to receive both the plaintext data encryption key (for local encryption) and the encrypted data key for storage; this enables client-side encryption of large objects without sending plaintext to KMS.
    - CORRECT: 'IntegrationLatency' measures the time taken by the backend integration (for example, Lambda) to respond to API Gateway, and 'Latency' measures the total client-perceived latency; both help diagnose timeouts.
    - CORRECT: CloudFront with signed URLs in front of S3 provides global low-latency delivery and controlled access to downloads at low cost, making it an efficient choice for firmware distribution.
    - CORRECT: Implementing exponential backoff for retries is the recommended approach to handle DynamoDB throttling errors, reducing retry pressure and allowing operations to succeed as capacity becomes available.
    - CORRECT: Amazon ElastiCache (Redis or Memcached) offers in-memory session storage with low latency and options for replication and high availability, making it well-suited for session state in scalable applications.
    - CORRECT: The AWS Serverless Application Model (SAM) provides a simplified syntax for declaring serverless resources (API Gateway, Lambda, DynamoDB) in CloudFormation templates.
    - CORRECT: Moving session state to a scalable managed store like DynamoDB and using an ELB with an Auto Scaling group for the web tier are effective refactors to increase elasticity.
    - CORRECT: AWS X-Ray provides distributed tracing that helps correlate calls across components, identify latencies and errors, and pinpoint root causes in production systems.
    - CORRECT: CloudWatch metric filters start producing metrics only for log events that occur after the filter is created; they do not retroactively create metrics for past log entries.
    - CORRECT: The 'Transform' section must be present in the template root to indicate the SAM transform, which enables the use of SAM shorthand resources.
    - CORRECT: Amazon ElastiCache provides an in-memory cache (Redis or Memcached) which reduces latency and database load for frequently-read data.
    - CORRECT: Setting a reserved concurrency limit on the second Lambda function prevents it from consuming the entire account concurrency pool and ensures capacity remains for other functions.
    - CORRECT: ElastiCache for Redis provides in-memory session storage with options for replication and high availability, making sessions fault tolerant and reducing downtime.
    - CORRECT: Files inside '.ebextensions' must have a '.config' extension to be processed by Elastic Beanstalk; renaming 'healthcheckurl.yaml' to 'healthcheckurl.config' will allow the settings to be applied.
    - CORRECT: Increasing the memory allocation for a Lambda function also increases the proportionate CPU available to the function, which can improve compute performance.
    - CORRECT: Caching user data in ElastiCache reduces database read latency, and making database calls asynchronous allows the application to continue processing without blocking while waiting for the DB response.
    - CORRECT: Cognito Sync (or the equivalent data sync features) allows synchronizing user profile data across devices associated with an identity without requiring a custom backend, enabling updates to be propagated to all devices.
    - CORRECT: After creating an API key, the key must be associated with a usage plan and the API stage by calling 'createUsagePlanKey', which binds the API key to the usage plan that is attached to the API stage and allows requests to be authorized.
    - CORRECT: Amazon Cognito with web identity federation lets users sign in using Amazon, Facebook, Google, and other social identity providers and exchange those tokens for temporary AWS credentials to access S3 securely.
    - CORRECT: Installing the CloudWatch Logs agent on the EC2 instance allows the application log files to be sent to CloudWatch Logs where administrators can view, search, and create metrics or alarms.
    - CORRECT: Creating a fresh table for the batch load and deleting the table afterward is the most efficient approach when the data is transient, because deleting the table removes all items instantly and avoids millions of delete operations.
    - CORRECT: If the Lambda function fails during processing, the service may retry the invocation, which produces duplicate log entries with the same original request ID when the retry succeeds or logs again.
    - CORRECT: Amazon API Gateway provides a single front-door for multiple backend services, enabling unified routing, throttling, authentication, and monitoring for many consumers and simplifying the architecture.
    - CORRECT: Hosting static website files in S3 and distributing them globally with CloudFront is the standard serverless pattern for static websites with low cost and high performance.
    - CORRECT: Creating custom metrics in a dedicated namespace with unique metric names for each application allows you to plot them together on a single CloudWatch dashboard for easy monitoring.
    - CORRECT: Cognito user pools manage user directories, authentication, and self-service password reset, and can be combined with identity pools to grant temporary AWS credentials for access to AWS resources.
    - CORRECT: AWS Data Pipeline can be used to orchestrate and schedule a series of data-processing tasks across environments, though for application deployments a CI/CD toolchain would usually be preferred.
    - CORRECT: Adding a random suffix (or otherwise salting) to the partition key distributes writes across more partitions and prevents a hot partition during spikes, which can be a low-cost fix.
    - CORRECT: Amazon ElastiCache provides a managed in-memory store with replication and persistence options that can be used to accumulate results with low latency while minimizing inconsistency during scaling.
    - CORRECT: Elastic Beanstalk multi-container Docker environments use ECS task definitions to describe the containers, ports, and resource requirements for container instances.
    - CORRECT: Using an EC2 instance profile (IAM role attached to the instance) provides temporary credentials to the applications running on the instance without hardcoding credentials and with minimal management overhead.
    - CORRECT: Publishing a custom CloudWatch metric for callbacks and using CloudWatch alarms is cost-effective and provides rolling statistics, retention, and automated alerting without building additional infrastructure.
    - CORRECT: Immutable deployments create a separate set of instances with the new version and switch traffic only after they are healthy, enabling safe rollbacks and minimizing downtime if an update fails.
    - CORRECT: Placing ElastiCache in front of the database for frequently-read items reduces database load and latency and is an efficient way to handle read spikes.
    - CORRECT: A strongly consistent read of a 7KB item consumes 2 read capacity units (because reads >4KB round up), so 3 reads/s require 6 RCUs. Writes of 7KB consume 1 WCU per write rounded up to the 1 KB increment multiplied accordingly; 10 writes/s would require provisioning the equivalent (commonly calculated to 70 WCU in this option's context).
    - CORRECT: If a Lambda function errors while processing Kinesis records, Lambda will retry processing those records which can result in duplicates; proper error handling or checkpointing is required to avoid repeated processing.
    - CORRECT: AWS Systems Manager Parameter Store SecureString provides encrypted secret storage with rotation support and allows the application to retrieve secrets at runtime without code changes when secrets rotate.
    - CORRECT: Calling 'update-function-code' points Lambda to the new S3 object or updates the function's code directly, which is the least disruptive way to instruct Lambda to use the new deployment package.
    - CORRECT: Associating the Lambda function with the VPC private subnets lets it access RDS in the VPC, and adding a NAT Gateway provides outbound internet access from those private subnets so the function can reach public endpoints.
    - CORRECT: When CloudFormation manages function code via S3, you must update the stack with the new S3Key or S3ObjectVersion so CloudFormation updates the Lambda resource to point to the new package.
    - CORRECT: For ECS, run the X-Ray daemon as a sidecar container (or Docker image), instrument your application code to emit trace segments, and assign an IAM role to the ECS task so the daemon can send trace data to X-Ray.
    - CORRECT: Enabling S3 default encryption ensures objects are encrypted at rest using the chosen encryption method (SSE-S3, SSE-KMS, etc.) and satisfies data-at-rest encryption requirements.
    - CORRECT: The 'Mappings' section in CloudFormation allows you to provide region-specific values (such as AMI IDs) and look them up in the template so the correct AMI is used per region.
    - CORRECT: Performing a Query on the GSI with eventually-consistent reads consumes the least RCU for the targeted set of items because Query restricts reads to matching keys and eventual consistency halves the RCU cost compared to strong consistency.
    - CORRECT: Creating an invalidation for the changed objects forces CloudFront edge caches to fetch the updated content from the origin so users see the new version.
    - CORRECT: You can include inline code in the CloudFormation template (for small functions) or reference a ZIP file in S3 from an 'AWS::Lambda::Function' resource to deploy the function via CloudFormation.
    - CORRECT: Bundling custom libraries with your function code into the deployment ZIP ensures the runtime has the dependencies available at invocation time and is the recommended method.
    - CORRECT: Terminating SSL at the ELB by configuring SSL certificates on the load balancer offloads the CPU-intensive TLS work from the EC2 instances and secures traffic.
    - CORRECT: Packaging the function code together with all required native and language libraries in the deployment ZIP ensures dependencies are available to the Lambda runtime at execution time.
    - CORRECT: Storing session state in DynamoDB provides a highly available, durable, and scalable backend so sessions are preserved even if individual EC2 instances fail.
    - CORRECT: DynamoDB Streams captures item-level changes and can be consumed to propagate updates to other services or databases in near-real time, providing a decoupled and reliable replication mechanism.
    - CORRECT: AWS CodeCommit is a managed Git service that supports distributed version control where developers can work offline and synchronize changes peer-to-peer when connected.
    - CORRECT: Creating a CloudWatch Events (EventBridge) scheduled rule is a serverless way to trigger a Lambda function on a cron or fixed-rate schedule, such as every 10 minutes.
    - CORRECT: Creating a GSI with 'sport_name' as the partition key and 'score' as the sort key allows efficient queries for top performers per sport without scanning the entire table.
    - CORRECT: Amazon Cognito supports unauthenticated identities via identity pools, allowing anonymous users to receive temporary, limited-privilege AWS credentials without requiring login.
    - CORRECT: Granting decryption permissions via an S3 bucket policy and ensuring the EC2 instance IAM role has KMS permissions allows the EC2 application to access SSE-KMS encrypted objects; both S3 policies and IAM role permissions are commonly used together to enable access.
    - CORRECT: A delay queue causes messages to become visible to consumers only after a configurable delay period after they are sent, effectively hiding new messages temporarily.
    - CORRECT: Using CodeCommit gives distributed developers a managed Git repository with efficient incremental transfers and integrates with deployment pipelines to Elastic Beanstalk, minimizing upload time and administrative overhead.
    - CORRECT: Amazon DynamoDB Accelerator (DAX) is an in-memory caching service designed specifically for DynamoDB to speed up repeated read requests with microsecond latency.
    - CORRECT: Client-side encryption with KMS-managed keys ensures sensitive data is encrypted before transmission and stored in S3 in encrypted form, while KMS and client-side logging can ensure access auditability and protect data end-to-end.
    - CORRECT: The STS response includes the temporary credentials tied to the IAM principal (the Access Key ID shown), so the permissions used are those associated with that IAM principal.
    - CORRECT: Using pagination for CLI list calls retrieves results in smaller chunks and prevents timeouts when listing large numbers of resources.
    - CORRECT: Port mappings for containers are defined in the ECS task definition which describes how container ports map to host ports and how networking should be configured.
    - CORRECT: Amazon DynamoDB provides single-digit millisecond latency for key-value lookups, making it an appropriate choice for indexing metadata that must be retrieved quickly.
    - CORRECT: Amazon CloudWatch Logs is the service designed to collect and securely store application logs from EC2 instances and other resources in a centralized place for monitoring and analysis.
    - CORRECT: Using the Kinesis Producer Library can optimize batching and aggregation of records on the producer side, improving throughput and helping streams accommodate high peak rates.
    - CORRECT: Breaking a large template into nested stacks for common patterns increases maintainability and reuse and is a recommended CloudFormation best practice.
    - CORRECT: Implementing exponential backoff in the application reduces the rate of retry attempts when throttling or rate limits are encountered and is the recommended pattern for handling 'LimitExceeded' errors from AWS services.
    - CORRECT: Enabling DynamoDB Time To Live (TTL) on an attribute containing the expiration timestamp automatically removes expired items without custom code or additional infrastructure.
    - CORRECT: Using asynchronous (Event) Lambda invocations allows the processing of many files in parallel without waiting for each invocation to return, which is the fastest approach when individual results are not needed synchronously.
    - CORRECT: The S3 multipart upload API lets you upload large objects in parts and is the supported method for uploading objects larger than the single PUT limit, enabling a 15 GB upload.
    - CORRECT: Developers must first run the AWS CLI command that returns Docker login credentials (e.g., the output of 'aws ecr get-login' or the modern 'aws ecr get-login-password' piped into 'docker login') and then run 'docker pull REPOSITORY_URI:TAG' to pull the image.
    - CORRECT: Amazon Cognito user pools provide a scalable user directory, sign-up and sign-in flows, and user attribute storage suitable for millions of users.
    - CORRECT: Granting the Lambda function an execution role with the specific S3 permissions it needs follows least-privilege and is the secure best practice for giving the function access to the bucket.
    - CORRECT: To encrypt traffic end-to-end, configure CloudFront's Viewer Protocol Policy to require HTTPS from clients and set the Origin Protocol Policy to 'HTTPS Only' so CloudFront communicates with the origin over TLS.
    - CORRECT: A strongly consistent read of a 5 KB item consumes 2 read capacity units (RCU) because reads are calculated per 4 KB chunk; for 100 reads/sec you need 100 * 2 = 200 RCUs.
    - CORRECT: Lambda function logs are sent to Amazon CloudWatch Logs by default, so the Developer should look in CloudWatch to examine function error logs and execution traces.
    - CORRECT: Lambda provides ephemeral disk space at '/tmp' (typically 512 MB or configurable) for temporary files during execution; using '/tmp' is the most efficient approach for transient storage.
    - CORRECT: AWS Elastic Beanstalk provides a managed platform for running web applications on Tomcat without needing to manage underlying infrastructure, making it the easiest deployment option for this scenario.
    - CORRECT: Amazon ElastiCache is a shared, in-memory store that provides low-latency access to session data across multiple instances, making it ideal for session storage behind a load balancer.
    - CORRECT: Amazon SQS (queues) and Amazon SNS (pub/sub) provide managed asynchronous messaging patterns that help microservices communicate without tight coupling and without degrading performance.
    - CORRECT: Best practices are to delete root user access keys and to rely on IAM roles instead of long-lived access keys wherever possible to reduce risk and management overhead.
    - CORRECT: Assigning an IAM role to the EC2 instance (instance profile) provides temporary credentials to make AWS API calls securely without embedding static credentials.
    - CORRECT: ALBs add an 'X-Forwarded-For' header containing the original client IP; modifying the application to read this header preserves horizontal scalability while obtaining client IPs.
    - CORRECT: To separate the RDS instance from an Elastic Beanstalk-managed environment, the recommended approach is to create a new environment without RDS and migrate the application to use an externally managed RDS instance.
    - CORRECT: Common reasons why CodeDeploy did not run include pushing the change to a non-master branch (so the pipeline wasn't triggered) or a failure in an earlier pipeline stage that prevented deployment from continuing.
    - CORRECT: Cognito's push synchronization feature allows updates to be pushed to devices silently when appropriate permissions and IAM roles are configured, enabling seamless sync notifications.
    - CORRECT: Running the traditional LAMP stack on EC2 with a managed relational backend like Amazon Aurora (MySQL-compatible) provides a direct and flexible way to host the application on AWS.
    - CORRECT: Long polling with a shorter wait interval reduces empty responses and allows the consumer to receive messages as soon as they arrive, minimizing the delay between message arrival and dashboard update.
    - CORRECT: Moving both shared images and cache data to S3 centralizes storage and allows multiple horizontally scaled instances to access the same data without relying on local disks.
    - CORRECT: Enabling DynamoDB Streams and configuring an event source mapping so Lambda is invoked directly from the stream is the standard way to trigger functions on item lifecycle events.
    - CORRECT: The most common cause of 'command not found' is that the 'aws' executable is not on the system PATH, so the shell cannot locate the CLI program.
    - CORRECT: Using SQS with an Auto Scaling group that scales based on queue depth lets you elastically provision workers to handle long-running fraud checks and cope with peak order rates without over-provisioning.
    - CORRECT: Storing configuration and secrets in Systems Manager Parameter Store and retrieving them at build time reduces the size of inlined environment variables and is the recommended approach for large or sensitive values.
    - CORRECT: API Gateway honors cache-control headers from clients; by passing 'Cache-Control: max-age=0' in the request, clients can force cache revalidation/expiration for their requests.
    - CORRECT: Using S3 Event Notifications to trigger a Lambda that updates DynamoDB provides near-real-time updates and is cost-effective because it is serverless and reacts only to object changes.
    - CORRECT: AWS Serverless Application Model (SAM) supports inline or referenced Swagger/OpenAPI definitions for API Gateway resources, enabling consistent, repeatable deployments of serverless APIs.
    - CORRECT: Adding an S3 event notification that triggers a new Lambda function to generate thumbnails decouples thumbnail work from upload processing and ensures uploads are not delayed while minimizing changes to existing code.
    - CORRECT: Deploying a new API stage (for example 'v2') in API Gateway and exposing its URL lets existing clients continue using 'v1' while others migrate to 'v2', providing a safe migration path.
    - CORRECT: Amazon Cognito user pools can federate OpenID providers and issue JWTs, and using a custom authorizer in API Gateway lets you implement a custom authorization model securely and simply.
    - CORRECT: Elastic Beanstalk configuration files with the '.config' extension must be placed in the '.ebextensions' folder at the root of the application source bundle to be processed.
    - CORRECT: Reusing a database connection across invocations by placing it in the function's global scope reduces connection setup overhead and improves performance for frequently-invoked Lambda functions.
    - CORRECT: Browsers enforce same-origin policies; if JavaScript in one bucket tries to access resources in another bucket, the target bucket must have CORS configured to allow those requests.
    - CORRECT: Adding random prefixes to key name prefixes (for example adding random hex to folder names) distributes writes across S3's internal partitions and helps avoid hot spots when handling very high PUT rates.

---

### Task 2 — Develop code for AWS Lambda

**Knowledge of:**
- Event source mapping
- Stateless applications
- Unit testing
- Event-driven architecture
- Scalability
- Accessing private resources in VPCs from Lambda code
  - CORRECT: AWS Step Functions provides a managed workflow orchestration service with state management, retries, and visual debugging, making it suitable to replace fragile custom state machine code.
  - CORRECT: Defining distinct IAM roles for each ECS task and referencing them in task definitions follows the principle of least privilege and allows containers to run with specific permissions regardless of the underlying EC2 instance role, while supporting bin packing.
  - CORRECT: AWS Step Functions can manage long-running workflows, execute tasks in parallel, provide durable state, and handle retries and waits, which makes it ideal for a process that can span days.

**Skills in:**
- Configuring Lambda functions by defining environment variables and parameters (for example, memory, concurrency, timeout, runtime, handler, layers, extensions, triggers, destinations)
- Handling the event lifecycle and errors by using code (for example, Lambda Destinations, dead-letter queues)
- Writing and running test code by using AWS services and tools
- Integrating Lambda functions with AWS services
    - CORRECT: You must enable the multi-value headers feature on the ALB so that headers with multiple values are delivered to the Lambda function exactly as sent by the client.
    - CORRECT: The instance metadata endpoint (169.254.169.254) provides the public IP address programmatically and reliably.
    - CORRECT: Caching the file in '/tmp' allows reusing the file between invocations within the same Lambda container and reduces repeated downloads, improving performance.
    - CORRECT: The '/tmp' directory is the local temporary storage available to Lambda functions and is appropriate for small files that are used during execution and do not need persistence.
    - CORRECT: The Lambda context object contains a request ID for the invocation; writing logs to the console lets CloudWatch capture them and associate logs with that request ID.
    - CORRECT: Reducing package size and moving RDS connection initialization outside the handler reduce cold start time and avoid recreating connections on each invocation, improving latency without extra cost.
    - CORRECT: Breaking the logic into multiple smaller Lambda functions reduces package size, fits within Lambda limits, and improves maintainability and deployment reliability compared to trying to circumvent size limits.
    - CORRECT: Instantiating clients outside the handler enables connection reuse across invocations in the same execution environment, reducing latency and cold-start overhead by avoiding repeated client initialization.
    - CORRECT: Environment variables allow a single Lambda function package to reference different resource endpoints and configuration per deployment environment, enabling reuse across dev/test/prod without code changes.
    - CORRECT: The most likely cause is that the Lambda function needs more memory because processing large images is memory and CPU intensive; increasing memory also increases CPU and can reduce execution time to complete the processing within Lambda limits.
    - CORRECT: Adding logging statements in the Lambda code ensures errors are written to CloudWatch Logs automatically, providing administrators with direct, searchable error information for troubleshooting.
    - CORRECT: Packaging the function with its dependencies in a zip and uploading it ensures Lambda has the required modules available in the execution environment, resolving import errors.
    - CORRECT: If the Lambda execution role lacks permissions to create log groups or put log events, then no logs will be written to CloudWatch even though the function runs, so ensuring the role has CloudWatch Logs permissions fixes this.
    - CORRECT: When using ALB with Lambda targets, you must grant permission for the ALB to invoke the function (via lambda:AddPermission). Missing invoke permissions prevent the ALB from calling the Lambda.
    - CORRECT: Lambda automatically scales out by running multiple concurrent executions to handle increased event traffic, allowing many image-resize tasks to run in parallel.
- Tuning Lambda functions for optimal performance

---

### Task 3 — Use data stores in application development

**Knowledge of:**
- Relational and non-relational databases
- Create, read, update, and delete (CRUD) operations
- High-cardinality partition keys for balanced partition access
- Cloud storage options (for example, file, object, databases)
    - CORRECT: The correct options (ElastiCache, DynamoDB, and S3) can be used as key/value stores: ElastiCache stores key/value pairs in memory, DynamoDB is a NoSQL key/value database, and S3 objects are accessed by a key.
- Database consistency models (for example, strongly consistent, eventually consistent)
    - CORRECT: Strongly consistent reads consume more RCUs than eventually consistent reads because they require immediate confirmation of the latest data.
    - CORRECT: Eventually consistent reads consume half the read capacity of strongly consistent reads for the same item size, so 5 RCUs of eventually consistent reads yield more effective throughput than the equivalent strongly consistent option.
- Differences between query and scan operations
- Amazon DynamoDB keys and indexing
    - CORRECT: Creating a GSI with a minimal set of projected attributes returns only the required data for queries and reduces RCU consumption while improving performance.
    - CORRECT: A unique attribute like 'reviewID' provides a high-cardinality partition key which evenly distributes items across partitions, yielding the most consistent performance for a very large dataset.
    - CORRECT: Performing a Query on the GSI with eventually-consistent reads consumes the least RCU for the targeted set of items because Query restricts reads to matching keys and eventual consistency halves the RCU cost compared to strong consistency.
- Caching strategies (for example, write-through, read-through, lazy loading, TTL)
    - CORRECT: ElastiCache speeds up frequent reads by storing data in memory, reducing latency and increasing throughput for read-heavy workloads. It also helps applications that benefit from in-memory caching to avoid repeated computational work.
    - CORRECT: The correct options (ElastiCache, DynamoDB, and S3) can be used as key/value stores: ElastiCache stores key/value pairs in memory, DynamoDB is a NoSQL key/value database, and S3 objects are accessed by a key.
    - CORRECT: Writing to the backend first and then invalidating the cache ensures strong consistency because the database remains the source of truth and the cache is invalidated so subsequent reads get the updated data.
    - CORRECT: Using CloudFront reduces global latency and offloads traffic from S3 by delivering images via a CDN.
    - CORRECT: Enabling cache only when required for development and test avoids continuous provisioned cache costs while keeping production appropriately configured.
    - CORRECT: Using ElastiCache with a cache-aside strategy allows the application to read from cache when available and update the cache when needed, reducing database load and page latency.
    - CORRECT: If the cache is not invalidated or updated when the underlying price changes, the application will continue to serve stale data from ElastiCache, causing the observed inconsistency.
    - CORRECT: Redis in ElastiCache Cluster Mode provides a managed, highly available in-memory cache that supports clustering and replication, making it suitable for cached content that is costly to regenerate while maximizing uptime.
    - CORRECT: Placing ElastiCache in front of the database for frequently-read items reduces database load and latency and is an efficient way to handle read spikes.
- Amazon Simple Storage Service (Amazon S3) tiers and lifecycle management
- Differences between ephemeral and persistent data storage patterns
    - CORRECT: Directing read queries to read replicas offloads the primary database and improves read performance for read-heavy workloads.
    - CORRECT: Creating a read replica and directing read traffic to it isolates read load from write activity on the primary, eliminating the write-induced slowdown for readers.

**Skills in:**
- Serializing and deserializing data to provide persistence to a data store
- Using, managing, and maintaining data stores
- Managing data lifecycles
- Using data caching services
  - CORRECT: 'TransactWriteItems' provides atomic, all-or-nothing writes across multiple items in DynamoDB.
  - CORRECT: Implementing exponential backoff reduces request collisions with provisioned throughput, and switching to on-demand mode lets the table scale automatically to handle spikes.
  - CORRECT: Creating a mapping template transforms query string parameters into the JSON payload or format expected by the Lambda handler.
  - CORRECT: Using DynamoDB Time To Live (TTL) with a numeric timestamp attribute automatically and cost-effectively removes items after 48 hours without extra compute or scanning, which is ideal for high-volume ephemeral data.
  - CORRECT: Conditional writes allow you to specify a condition (for example only update if the current value matches an expected value) which prevents accidental overwrites in concurrent update scenarios.
  - CORRECT: You must configure an event source mapping between the DynamoDB stream and the Lambda function so that stream records trigger Lambda invocations.
  - CORRECT: Updates to the primary table must also be written to the GSI; if the GSI's write capacity is underprovisioned, writes to the primary table can be throttled even while the table's own WCU appear available.
  - CORRECT: Storing images in S3 and adding a pointer in DynamoDB keeps the table lightweight and minimizes provisioned throughput consumption.

---

## Content Domain 2 — Security

### Task 1 — Implement authentication and/or authorization for applications and AWS services

**Knowledge of:**
- Identity federation (for example, Security Assertion Markup Language [SAML], OpenID Connect [OIDC], Amazon Cognito)
- Bearer tokens (for example, JSON Web Token [JWT], OAuth, AWS Security Token Service [AWS STS])
- Comparison of user pools and identity pools in Amazon Cognito
- Resource-based policies, service policies, and principal policies
- Role-based access control (RBAC)
- Application authorization that uses ACLs
- Principle of least privilege
- Differences between AWS managed policies and customer-managed policies
- Identity and access management

**Skills in:**
- Using an identity provider to implement federated access (for example, Amazon Cognito, AWS Identity and Access Management [IAM])
- Securing applications by using bearer tokens
- Configuring programmatic access to AWS
- Making authenticated calls to AWS services
- Assuming an IAM role
    - CORRECT: Configuring cross-account IAM roles in the audited accounts and having the application in Account A assume those roles is the most secure approach, because each account retains control and temporary credentials are used.
    - CORRECT: The EC2 role must be permitted to assume the AccessPII role, and the application should call 'AssumeRole' to obtain temporary credentials that allow access to the PII table in the other account.
    - CORRECT: Creating a cross-account IAM role and using STS AssumeRole grants short-lived credentials with scoped permissions and is the recommended secure method for temporary cross-account access.
    - CORRECT: Federating the SAML directory through a Cognito identity pool allows users to authenticate via SAML without mirroring identities on AWS, and using the 'cognito-identity.amazonaws.com:sub' condition lets you grant per-user access to resources.
    - CORRECT: Use Amazon Cognito to issue temporary credentials for authenticated and unauthenticated users, and use role assumption via STS for fine-grained access control; both approaches scale and avoid embedding static credentials.
- Defining permissions for principals
    - CORRECT: Using IAM policy conditions (for example with condition keys like 'aws:username' or 's3:prefix') can generalize the policy so it enforces per-user access control without creating separate policies per user.
    - CORRECT: Restricting access based on primary key values in IAM policies or application logic enforces per-user access control at the item level, ensuring users can only access their own data.

---

### Task 2 — Implement encryption by using AWS services

**Knowledge of:**
- Encryption at rest and in transit
    - CORRECT: Transferring data over SSL/TLS protects the channel (encryption in transit), and client-side encryption ensures data is encrypted before it leaves the application, satisfying requirements for data in transit.
    - CORRECT: Using encrypted EBS volumes provides at-rest encryption managed by the service without changing the application and with minimal performance impact.
    - CORRECT: A bucket policy that explicitly denies requests where 'SecureTransport' is false enforces that only HTTPS/TLS requests are accepted by the bucket.
    - CORRECT: A bucket policy that denies uploads missing the 'x-amz-server-side-encryption' header enforces encryption at upload time and prevents unencrypted objects from being stored in the bucket.
    - CORRECT: When a bucket uses SSE-KMS, the caller needs permission to use the KMS key for envelope key operations such as 'kms:GenerateDataKey'; granting this permission to the IAM user resolves the access denied error for PutObject.
    - CORRECT: Client-side encryption with a KMS-managed CMK allows the Security team to manage keys while ensuring data is encrypted before transmission to S3, satisfying the requirement that encryption happens client-side and keys are controlled by security.
    - CORRECT: Enabling S3 default encryption ensures objects are encrypted at rest using the chosen encryption method (SSE-S3, SSE-KMS, etc.) and satisfies data-at-rest encryption requirements.
    - CORRECT: Server-side encryption with customer-provided keys (SSE-C) lets you provide your own encryption keys from on-premises while S3 handles the encryption and storage, matching the requirement.
- Certificate management (for example, AWS Private Certificate Authority)
- Key protection (for example, key rotation)
    - CORRECT: SSE-KMS offers KMS-managed keys with additional control and auditing while offloading key management to AWS, meeting regulatory needs without fully managing keys in-house.
    - CORRECT: Server-side encryption with AWS KMS (SSE-KMS) allows AWS-managed encryption while using a customer-managed KMS key, giving control over the master key and supporting auditing and access control.
    - CORRECT: SSE-KMS requires calling KMS for envelope key operations, and the KMS API limits (request rate) can become the bottleneck when uploading massive numbers of objects, causing added latency.
    - CORRECT: AWS KMS supports automatic key rotation for customer-managed CMKs, which is the simplest built-in way to ensure keys are rotated annually.
    - CORRECT: SSE-KMS meets the audit requirement because AWS KMS provides key usage logs and audit trails via AWS CloudTrail, showing when and by whom the CMK was used.
    - CORRECT: The correct approach is to call 'aws logs associate-kms-key' (or use the console equivalent) to associate a KMS CMK ARN with an existing CloudWatch Logs log group so future log events are encrypted.
- Differences between client-side encryption and server-side encryption
- Differences between AWS managed and customer managed AWS Key Management Service (AWS KMS) keys
    - CORRECT: SSE-KMS provides server-side encryption integrated with AWS KMS and records a key usage audit trail without requiring application changes that would impact performance.
    - CORRECT: Calling 'GenerateDataKey' returns a plaintext data key and an encrypted copy; using the plaintext data key to encrypt the object locally before upload ensures the content is encrypted in transit and at rest.
    - CORRECT: Best practice is to call 'GenerateDataKey' to obtain a unique data key for each file, use that key to encrypt the file locally, and store the encrypted data key alongside the ciphertext for later decryption via KMS.
    - CORRECT: Generating a data key with GenerateDataKey and using the plaintext data key locally to encrypt large objects is the recommended envelope encryption approach for large data.

**Skills in:**
- Using encryption keys to encrypt or decrypt data
- Generating certificates and SSH keys for development purposes
- Using encryption across account boundaries
- Enabling and disabling key rotation

---

### Task 3 — Manage sensitive data in application code

**Knowledge of:**
- Data classification (for example, personally identifiable information [PII], protected health information [PHI])
- Environment variables
- Secrets management (for example, AWS Secrets Manager, AWS Systems Manager Parameter Store)
- Secure credential handling

**Skills in:**
- Encrypting environment variables that contain sensitive data
- Using secret management services to secure sensitive data
- Sanitizing sensitive data
- Storing connection strings and other secrets in Secrets Manager for runtime retrieval rather than hardcoding.
- Use 'aws configure' to set up CLI credentials for developers as a standard practice.
  - CORRECT: Configuring a CORS policy on the cdfonts bucket allows resources hosted on another domain to be loaded by the browser, resolving font blocking caused by same-origin policies.
  - CORRECT: Amazon Cognito provides synchronization features for user data across devices without requiring a full backend, enabling preferences and user data sync.
  - CORRECT: Amazon Cognito supports federated authentication including SAML 2.0, provides user sign-up and sign-in features, and scales without significant operational overhead, making it cost-effective for mobile apps.
  - CORRECT: Amazon Cognito supports unauthenticated (guest) identities alongside authenticated users, allowing limited access without full sign-in while integrating with identity providers for authenticated flows.
  - CORRECT: Option A includes conditions that allow the action only when the user is authenticated via web identity and enforces the correct condition to limit updates to the 'user_name' attribute.
  - CORRECT: Amazon Cognito provides user sign-in, sign-up, and profile management with support for multiple platforms and persistent user preferences, making it well-suited for application authentication across devices.
  - CORRECT: Creating a Cognito user pool and enabling MFA in that user pool provides managed user authentication with multi-factor capabilities suitable for mobile apps.
  - CORRECT: Amazon Cognito user pools provide user management, sign-up/sign-in, and federation with social identity providers, which matches the requirements.
  - CORRECT: Amazon Cognito supports MFA for user authentication flows and provides user management and secure delivery of verification codes, making it suitable for application-level MFA.

---

## Content Domain 3 — Deployment

### Task 1 — Prepare application artifacts to be deployed to AWS

**Knowledge of:**
- Ways to access application configuration data (for example, AWS AppConfig, Secrets Manager, Parameter Store)
- Lambda deployment packaging, layers, and configuration options
- Git-based version control tools (for example, Git)
- Container images

**Skills in:**
- Managing the dependencies of the code module (for example, environment variables, configuration files, container images) within the package
- Organizing files and a directory structure for application deployment
- Using code repositories in deployment environments
- Applying application requirements for resources (for example, memory, cores)
- Packaging the function code with required native/language libraries so Lambda runtimes have needed dependencies.
  - CORRECT: 'sam build' and 'sam deploy' are the standard workflow to build SAM artifacts and deploy the updated application to AWS.
  - CORRECT: 'Rolling with additional batch' adds temporary instances to maintain capacity during deployment, preventing visible capacity reduction while using the existing instances.
  - CORRECT: The correct options describe supported methods to create an application version (zip and upload via console or create via CLI) and then update the Elastic Beanstalk environment.
  - CORRECT: Rolling with additional batch keeps full capacity during updates by provisioning an extra batch during deployment while avoiding the higher cost of creating a full immutable environment, thus meeting both capacity and cost constraints.
  - CORRECT: Before deploying with SAM CLI, you must package the application (sam package or sam build/deploy) so local artifacts are prepared and uploaded to S3 for deployment.
  - CORRECT: The SAM workflow builds local artifacts, packages them (uploading to S3), and then deploys the packaged template from S3, which is the standard SAM deployment sequence.
  - CORRECT: Both the AWS CLI CloudFormation package/deploy commands and the SAM-specific package/deploy commands are valid ways to package and deploy SAM templates; using either approach automates artifact upload and stack deployment.

---

### Task 2 — Test applications in development environments

**Knowledge of:**
- Features in AWS services that perform application deployment
- Integration testing that uses mock endpoints
- Lambda versions and aliases

**Skills in:**
- Testing deployed code by using AWS services and tools
- Performing mock integration for APIs and resolving integration dependencies
- Testing applications by using development endpoints (for example, configuring stages in Amazon API Gateway)
- Deploying application stack updates to existing environments (for example, deploying an AWS SAM template to a different staging environment)

---

### Task 3 — Automate deployment testing

**Knowledge of:**
- API Gateway stages
- Branches and actions in the continuous integration and continuous delivery (CI/CD) workflow
- Automated software testing (for example, unit testing, mock testing)

**Skills in:**
- Creating application test events (for example, JSON payloads for testing Lambda, API Gateway, AWS SAM resources)
- Deploying API resources to various environments
- Creating application environments that use approved versions for integration testing (for example, Lambda aliases, container image tags, AWS Amplify branches, AWS Copilot environments)
- Implementing and deploying infrastructure as code (IaC) templates (for example, AWS SAM templates, AWS CloudFormation templates)
- Managing environments in individual AWS services (for example, differentiating between development, test, and production in API Gateway)
  - CORRECT: Change sets show the differences and the impact of changes before applying an update to the stack.
  - CORRECT: Uploading and deploying a new application version via the Elastic Beanstalk console is the supported flow for updating an application.
  - CORRECT: The canary deployment strategy using aliases and shifting 10% of traffic allows a gradual rollout and quick rollback with minimal user impact if errors occur.

---

### Task 4 — Deploy code by using AWS CI/CD services

**Knowledge of:**
- Git-based version control tools (for example, Git)
- Manual and automated approvals in AWS CodePipeline
- Access application configurations from AWS AppConfig and Secrets Manager
- CI/CD workflows that use AWS services
- Application deployment that uses AWS services and tools (for example, CloudFormation, AWS Cloud Development Kit [AWS CDK], AWS SAM, AWS CodeArtifact, AWS Copilot, Amplify, Lambda)
    - CORRECT: The supported flow is to upload the deployment bundle to S3 and instruct CodeDeploy to use that artifact for deploying to EC2 instances.
- Lambda deployment packaging options
- API Gateway stages and custom domains
- Deployment strategies (for example, canary, blue/green, rolling)

**Skills in:**
- Updating existing IaC templates (for example, AWS SAM templates, CloudFormation templates)
- Managing application environments by using AWS services
- Deploying an application version by using deployment strategies
- Committing code to a repository to invoke build, test, and deployment actions
- Using orchestrated workflows to deploy code to different environments
- Performing application rollbacks by using existing deployment strategies
- Using labels and branches for version and release management
- Using existing runtime configurations to create dynamic deployments (for example, using staging variables from API Gateway in Lambda functions)
  - CORRECT: Deploying each component in its own Elastic Beanstalk environment allows independent scaling according to each component's needs.
  - CORRECT: Using Lambda aliases and versions lets the API Gateway point to an alias and you can update the alias to point to a new version without changing the gateway endpoint.
  - CORRECT: 'appspec.yml' is the file used by CodeDeploy to define deployment actions and hooks; updating it (or ensuring it is present and correct) is required for CodeDeploy to apply the deployment.
  - CORRECT: CodeDeploy expects 'appspec.yml' at the root of the application bundle so it can find the deployment hooks and file mappings when executing a deployment.
  - CORRECT: Adding an approval action in a pipeline stage is the native CodePipeline mechanism to require human approval before progressing to deployment.

---

## Content Domain 4 — Troubleshooting and Optimization

### Task 1 — Assist in a root cause analysis

**Knowledge of:**
- Logging and monitoring systems
- Languages for log queries (for example, Amazon CloudWatch Logs Insights)
- Data visualizations
- Code analysis tools
- Common HTTP error codes
- Common exceptions generated by SDKs
- Service maps in AWS X-Ray

**Skills in:**
- Debugging code to identify defects
- Interpreting application metrics, logs, and traces
- Querying logs to find relevant data
- Implementing custom metrics (for example, CloudWatch embedded metric format [EMF])
- Reviewing application health by using dashboards and insights
- Troubleshooting deployment failures by using service output logs
  - CORRECT: Enabling AWS X-Ray tracing for the Lambda function provides distributed traces that show the time spent in DynamoDB API calls and helps identify bottlenecks.
  - CORRECT: Two common causes are a missing X-Ray daemon on the EC2 host and an instance role lacking 'xray:PutTraceSegments' and 'xray:PutTelemetryRecords' permissions, both preventing trace data from being sent to or accepted by X-Ray.
  - CORRECT: To capture traces from an EC2-hosted application, you must instrument the application with the X-Ray SDK and run the X-Ray daemon as a local process to buffer and send trace data to the X-Ray service.
  - CORRECT: Instrumenting the code to emit traces to AWS X-Ray and analyzing them in the X-Ray console helps locate latency hotspots and visualize where time is spent inside the Lambda function.
  - CORRECT: Enabling X-Ray on API Gateway and Lambda provides distributed tracing that shows end-to-end request timing and exposes bottlenecks across services.
  - CORRECT: To enable X-Ray tracing for Lambda, grant the function an execution role with X-Ray permissions and enable tracing in the function configuration so the platform can send traces.
  - CORRECT: Add annotations to segments in X-Ray; annotations are indexed and let you filter and query traces efficiently, so adding them in code and segment documents enables the desired indexing.
  - CORRECT: AWS X-Ray provides distributed tracing to visualize service maps and trace latencies across microservices, helping isolate the component or segment causing performance issues.
  - CORRECT: For ECS, run the X-Ray daemon as a sidecar container (or Docker image), instrument your application code to emit trace segments, and assign an IAM role to the ECS task so the daemon can send trace data to X-Ray.

---

### Task 2 — Instrument code for observability

**Knowledge of:**
- Distributed tracing
- Differences between logging, monitoring, and observability
- Structured logging
- Application metrics (for example, custom, embedded, built-in)

**Skills in:**
- Implementing an effective logging strategy to record application behavior and state
- Implementing code that emits custom metrics
- Adding annotations for tracing services
- Implementing notification alerts for specific actions (for example, notifications about quota limits or deployment completions)
- Implementing tracing by using AWS services and tools

---

### Task 3 — Optimize applications by using AWS services and features

**Knowledge of:**
- Caching
- Concurrency
- Messaging services (for example, Amazon Simple Queue Service [Amazon SQS], Amazon Simple Notification Service [Amazon SNS])

**Skills in:**
- Profiling application performance
- Determining minimum memory and compute power for an application
- Using subscription filter policies to optimize messaging
- Caching content based on request headers

---

*Version 1.3 — DVA-C02**Version 1.3 — DVA-C02*