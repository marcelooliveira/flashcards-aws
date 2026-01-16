| Q | E | P | S |
|---|---|---|---|
| Q: 51 | E: statistics from REST API | P: send daily HTML reports by email | S: EventBridge event, lambda, API + SES, send report by email |
| Q: 52 | E: migrate on-premises app | P: scalable, highly available file system, minimal overhead | S: EC2, Multi-AZ, EFS |
| Q: 53 | E: store accounting records in S3 | P: immediate access 1yr, archive 9yrs, prevent deletion, max resiliency | S: S3 Lifecycle to Glacier Deep Archive + S3 Object Lock compliance mode |
| Q: 54 | E: Windows file shares on EC2 | P: highly available, durable, preserve access | S: FSx for Windows File Server, Multi-AZ |
| Q: 55 | E: VPC with EC2 and RDS | P: only private EC2 access to RDS | S: security group allows inbound from private EC2 SG |
| Q: 56 | E: API Gateway public interface | P: custom domain, HTTPS, certificate | S: Regional API Gateway, ACM cert, Route 53 |
| Q: 57 | E: store accounting records in S3 | P: immediate access 1yr, archive 9yrs, prevent deletion, max resiliency | S: Rekognition for content detection + human review |
| Q: 58 | E: run critical apps in containers | P: scalable, available, no infra management | S: ECS on Fargate |
| Q: 59 | E: analyze clickstream data | P: transmit/process 30TB daily | S: Kinesis Data Streams + Firehose + S3 + Redshift |
| Q: 60 | E: website behind ALB | P: forward all requests to HTTPS | S: ALB listener rule to redirect HTTP to HTTPS |
| Q: 61 | E: EC2 app connects to RDS | P: no hardcoded DB creds, auto rotation | S: Secrets Manager, auto rotation, EC2 role |
| Q: 62 | E: public web app behind ALB | P: edge encryption, external CA cert, annual rotation | S: ACM import cert, apply to ALB, EventBridge notify |
| Q: 63 | E: social media image upload | P: detect inappropriate content, minimize dev effort | S: S3 PUT event + Lambda convert to jpg |
| Q: 64 | E: SharePoint on-premises | P: migrate, highly available, AD integration | S: FSx for Windows File Server + FSx File Gateway |
| Q: 65 | E: API Gateway + Lambda for reports | P: detect PHI in PDF/JPEG, least overhead | S: Textract + Comprehend Medical |
| Q: 66 | E: sensitive info in S3 | P: secure access from EC2 in VPC | S: S3 lifecycle to Standard-IA + delete after 4 years |
| Q: 67 | E: EC2 app processes SQS | P: ensure single message processing | S: ChangeMessageVisibility API, increase timeout |
| Q: 68 | E: hybrid AWS/on-premises | P: highly available, low latency, minimize cost | S: Direct Connect + VPN backup |
| Q: 69 | E: web app on EC2, Aurora | P: high availability, min downtime/data loss | S: Multi-AZ ASG + Multi-AZ DB + RDS Proxy |
| Q: 70 | E: HTTP app behind NLB | P: NLB not detecting HTTP errors, improve availability | S: Replace NLB with ALB, HTTP health checks, auto replace |
| Q: 71 | E: DynamoDB for customer info | P: RPO 15min, RTO 1hr | S: DynamoDB point-in-time recovery |
| Q: 72 | E: photo app uses S3 | P: reduce intra-region data transfer cost | S: S3 VPC gateway endpoint |
| Q: 73 | E: Linux app in private subnet, bastion in public | P: secure SSH from on-premises via bastion | S: Bastion SG allows company IP + app SG allows bastion private IP |
| Q: 74 | E: two-tier web app, SQL Server | P: secure SG config | S: Web SG allows 443 from all + DB SG allows 1433 from web SG |
| Q: 75 | E: multi-tier app, REST services | P: dropped transactions, modernize, efficient | S: API Gateway + Lambda + SQS |
| Q: 76 | E: 10TB daily data from factory | P: reliable, secure transfer to S3 | S: DataSync over Direct Connect |
| Q: 77 | E: real-time data ingestion | P: API, transform, store, least overhead | S: API Gateway + Kinesis + Lambda + Firehose + S3 |
| Q: 78 | E: DynamoDB user transactions | P: retain data 7 years, efficient | S: AWS Backup for DynamoDB |
| Q: 79 | E: DynamoDB for unpredictable traffic | P: cost optimization, idle mornings, fast spikes | S: On-demand capacity mode |
| Q: 80 | E: share AMI with MSP Partner | P: AMI encrypted with KMS, secure sharing | S: Modify KMS key policy, share AMI |
