# saa-05.md

| Q   | C   | P   | S   |
|-----|-----|-----|-----|
|201  | marketing communications, mobile app users, SMS, reply, store responses 1 year | need to send confirmation SMS, users reply, store for analysis | Pinpoint journey + Kinesis for archiving |
|202  | move data to S3, must be encrypted, key rotation every year | encrypt data at rest, rotate key annually | KMS CMK with auto rotation, S3 default encryption |
|203  | finance company, customers request appointments via text, invitations delayed as company expands | invitations slow to arrive | Auto Scaling group scales by SQS queue depth |
|204  | make data available to teams, analytics, manage fine-grained permissions, minimize overhead | provide analytics, fine-grained access | Lake Formation + Glue JDBC + S3 registered, Lake Formation controls |
|205  | CloudFront distribution, cost-effective, resilient website hosting, serve as origin | host website for CloudFront origin | S3 private bucket + OAI, upload via CLI |
|208  | move data EC2 → S3, no public internet, only EC2 can upload | ensure private upload, restrict access | S3 VPC endpoint + bucket policy for EC2 role |
|209  | ALB for load, distributed session data, code changes allowed | support distributed session management | ElastiCache for session data |
|211  | identify all tagged components, quickest solution | need quick global tag report | Resource Groups Tag Editor query |
|213  | protect ALB from app-level attacks (XSS, SQLi) | filter traffic, block attacks | AWS WAF rules associated with ALB |
|220  | API, lowest cost, infrequent requests | deliver compute at lowest cost | AWS Lambda (pay-per-execution) |
