# multiple_choice

## Amazon S3

- q10, q11, q12, q23, q24, q35, q75, q80, q95: Use Amazon S3 with CloudFront, CORS, presigned URLs, client-side or server-side encryption (SSE-KMS), and careful logging configuration to secure, deliver, and manage objects efficiently.
- q151, q176, q186, q195, q246: Use S3 for static assets and logs, generate presigned URLs for private downloads, and integrate with VPC endpoints or lifecycle policies for secure access and retention.

## Amazon DynamoDB

- q2, q18, q25, q30, q33, q44, q57, q61, q62, q68: Design DynamoDB with appropriate keys, global secondary indexes, TTL, transactions (TransactWriteItems), and exponential backoff to handle throughput and query patterns.
- q158, q318, q332: Size DynamoDB capacity considering item size, consistency model, and read/write requirements; use appropriate RCUs/WCUs and caching when needed.

## AWS Lambda

- q3, q5, q11, q24, q48, q52, q56, q60, q98, q112: Use Lambda event triggers (S3 events, CloudWatch Events), increase memory for CPU-intensive tasks, cache in `/tmp`, package dependencies via layers, and configure retries, DLQs, and tracing for observability.

## Amazon API Gateway

- q26, q34, q152, q168, q215, q307: Use mapping templates to transform requests, use stages and stage variables for versioning, apply usage plans and API keys for per-customer quotas, and enable CORS on methods when serving browser clients.

## Amazon EC2 and IAM Roles

- q9, q14, q29, q41, q96, q219: Launch EC2 with instance roles for secure, short-lived credentials, attach appropriate IAM trusts and pass-role permissions, and use metadata service to obtain instance information.

## Amazon RDS and Read Replicas

- q17, q43, q199: Offload reads to RDS read replicas to isolate read load from writes and improve read performance during heavy write activity.

## Amazon ElastiCache

- q1, q38, q59, q94, q101: Use ElastiCache (Redis) for low-latency session or profile caching, cache-aside patterns, and cluster mode for availability and resilience.

## Amazon SQS and SNS

- q46, q81, q92, q115: Use SQS (and Extended Client for large payloads) for decoupling and ordering with FIFO MessageGroupId; extend visibility timeout when processing long tasks; use SNS for notifications and fan-out patterns.

## AWS CloudFormation and SAM

- q13, q33, q56, q59, q120: Use CloudFormation change sets and SAM packaging/deploy workflows to package artifacts, preview changes, and automate serverless deployments with rollback capabilities.

## AWS KMS and Encryption

- q6, q20, q111, q114, q216: Use KMS for envelope encryption with GenerateDataKey for client-side encryption, and SSE-KMS for server-side encryption with audit trails and key rotation.

## Amazon Kinesis and Firehose

- q21, q49, q70, q72, q279: Use Kinesis Streams for real-time, ordered per-shard processing with multiple consumers; use Firehose for managed ingestion into S3; apply shard scaling, KPL, and high-resolution metrics for throughput.

## AWS IAM and STS

- q7, q27, q41, q84, q90, q99: Use IAM roles and STS AssumeRole for cross-account access and temporary credentials, create per-developer IAM users for local dev, and use the policy simulator and decode APIs to validate and debug permissions.

## Amazon Cognito

- q22, q46, q54, q58, q82, q93: Use Cognito for user authentication, SAML and social federation, unauthenticated guest access, synchronization across devices, MFA, and exchanging tokens for temporary AWS credentials.

## AWS CloudWatch and Observability

- q45, q47, q69, q85, q86, q142: Publish custom metrics via PutMetricData from instances with roles, create alarms and dashboards, retry API calls with exponential backoff on throttling, and instrument with X-Ray and CloudWatch Logs for tracing and monitoring.

## AWS Code* Services (CodeDeploy, CodePipeline, CodeBuild, CodeCommit)

- q8, q23, q50, q91, q97, q116: Upload artifacts to S3 for CodeDeploy, use CodePipeline approval actions for manual gating, integrate CodeCommit with CodePipeline, review CodeBuild logs for failures, and commit programmatically via Git in automation.

## Amazon API design, Load Balancing, and Elastic Beanstalk

- q36, q39, q63, q78, q126, q152: Use ELB+EC2 or API Gateway+Lambda for REST endpoints, deploy with Elastic Beanstalk and use rolling policies (with additional batch) to preserve capacity and minimize outages.

## AWS Step Functions

- q31, q44, q65, q67: Use Step Functions to orchestrate sequences and parallel tasks, enabling long-running workflows and orchestration of Lambda functions with retries and error handling.

## Amazon CloudFront and CDN

- q10, q75, q328: Use CloudFront to cache and deliver S3-hosted content globally; invalidate edge caches after updates and randomize S3 key prefixes to optimize high request rates.

## AWS X-Ray

- q42, q85, q106, q136: Instrument applications with X-Ray SDK and daemon (or enable tracing for Lambda) to inspect traces, segment timing, and identify function-level bottlenecks.

## Miscellaneous Cloud Concepts

- q4, q19, q28, q62, q69, q77: Apply patterns like write-back/invalidate caching for consistency, exponential backoff for throttling, choose consistency models with throughput implications, and be aware of service limits (KMS rate limits) when using managed encryption.


<!-- This file groups short correct statements by question type (multiple_choice) and by AWS service or cloud concept. Each bullet references one or more question ids from the provided exam files and gives a concise, correct assertion derived from those questions. -->