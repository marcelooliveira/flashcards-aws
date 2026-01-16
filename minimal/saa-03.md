| Q | E | P | S |
|---|---|---|---|
| Q: 101 | E: VPC with public/private subnets | P: private subnets need internet for EC2 updates | S: NAT gateway per AZ, route table per AZ |
| Q: 102 | E: migrate SFTP server with NFS data | P: automate transfer to EC2/EFS | S: DataSync agent + EC2 in same AZ as EFS |
| Q: 103 | E: Glue ETL job on S3 XML | P: prevent reprocessing old data | S: Glue job bookmarks |
| Q: 104 | E: website on EC2, Windows | P: mitigate large-scale DDoS, no downtime | S: Shield Advanced + CloudFront |
| Q: 105 | E: serverless workload, Lambda | P: least privilege for EventBridge invoke | S: Lambda resource policy for events.amazonaws.com |
| Q: 106 | E: confidential S3 data | P: encrypt at rest, log key use, rotate yearly | S: SSE-KMS with auto rotation |
| Q: 107 | E: track bike locations, multi-tier | P: REST API, analytics platform | S: API Gateway + Kinesis Data Analytics |
| Q: 108 | E: RDS for auto sales, remove sold | P: send data to multiple targets | S: Lambda on RDS update, send to SQS |
| Q: 109 | E: S3 data must be unchangeable | P: objects unchangeable until allowed, restrict delete | S: S3 Object Lock legal hold + IAM for delete |
| Q: 110 | E: social media image upload | P: decouple, improve upload perf | S: S3 upload + S3 event triggers Lambda resize |
| Q: 111 | E: ActiveMQ/MySQL on EC2 | P: high availability, low complexity | S: Amazon MQ active/standby + ASG + RDS Multi-AZ |
| Q: 112 | E: containerized web app on-prem | P: move to AWS, min code/dev effort | S: ECS Fargate + ALB |
| Q: 113 | E: move 50TB reporting data | P: no network bandwidth, run transform in AWS | S: Snowball Edge + Glue job |
| Q: 114 | E: image app, EC2 + DynamoDB | P: scale for variable users | S: Lambda for photos + S3 + DynamoDB |
| Q: 115 | E: EC2 in public subnet, S3 access | P: private route for file transfers | S: move EC2 to private subnet + S3 VPC endpoint |
| Q: 116 | E: CMS website, patching burden | P: static, scalable, secure, low overhead | S: S3 static hosting + CloudFront HTTPS |
| Q: 117 | E: CloudWatch Logs to OpenSearch | P: near-real time, least overhead | S: Kinesis Firehose from log group to OpenSearch |
| Q: 118 | E: web app, 900TB text docs | P: scalable, cost-effective storage | S: Amazon S3 |
| Q: 119 | E: API Gateway REST APIs, multi-Region | P: protect from SQLi/XSS, least admin | S: WAF web ACLs on API stages |
| Q: 120 | E: DNS on EC2/NLB in 2 Regions | P: improve perf/availability, route traffic | S: Route 53 geolocation + CloudFront |
| Q: 121 | E: RDS unencrypted, Multi-AZ | P: ensure DB/snapshots always encrypted | S: encrypt snapshot, restore new encrypted instance |
| Q: 122 | E: scalable key management infra | P: reduce operational burden | S: AWS KMS |
| Q: 123 | E: EC2 web app, SSL bottleneck | P: increase performance | S: ACM cert + ALB HTTPS listener |
| Q: 124 | E: dynamic batch job on EC2 | P: scalable, cost-effective | S: EC2 Spot Instances |
| Q: 125 | E: 2-tier ecommerce, private EC2/RDS | P: internet for EC2, high availability | S: ASG in private subnets + RDS Multi-AZ + NAT gateways + ALB in public subnets |
| Q: 126 | E: S3 Standard, 25yr retention | P: 2yr immediate, 23yr archive, reduce cost | S: Lifecycle to Glacier Deep Archive after 2yr |
| Q: 127 | E: media co, video/content/archive | P: max I/O, durability, archive | S: EBS for video, S3 for content, Glacier for archive |
| Q: 128 | E: run containers in AWS | P: stateless, tolerate disruption, minimize cost | S: Spot Instances in EC2 ASG + EKS node group |
| Q: 129 | E: multi-tier app on-prem, containerized | P: reduce overhead, improve infra | S: Aurora for DB + Fargate ECS for app |
| Q: 130 | E: EC2 ASG, app best at 40% CPU | P: maintain performance | S: target tracking scaling policy |
| Q: 131 | E: S3 file sharing via CloudFront | P: block direct S3 access | S: OAI for CloudFront, S3 bucket only OAI read |
| Q: 132 | E: website with downloadable reports | P: global scale, cost-effective, fast | S: CloudFront + S3 |
| Q: 133 | E: on-prem Oracle DB, upgrade/migrate | P: minimize ops, DR, OS access | S: RDS Custom for Oracle + cross-region read replica |
| Q: 134 | E: serverless SQL on S3, encrypt/replicate | P: least overhead | S: S3 CRR + SSE-KMS + Athena |
| Q: 135 | E: connect to provider service privately | P: restrict to target, only from company VPC | S: provider VPC endpoint + PrivateLink |
| Q: 136 | E: migrate on-prem PostgreSQL to Aurora | P: keep online, sync | S: DMS ongoing replication + SCT for schema |
| Q: 137 | E: missed root email notification | P: future notifications to admins only | S: AWS account alternate contacts |
| Q: 138 | E: ecommerce, RabbitMQ/PostgreSQL on EC2 | P: highest availability, least overhead | S: Amazon MQ active/standby + ASG + RDS Multi-AZ |
| Q: 139 | E: S3 files for QuickSight, SageMaker | P: automate move, Lambda pattern match, pipeline | S: Lambda copy on S3 event + event notification to SageMaker |
| Q: 140 | E: app with EC2, Fargate, Lambda | P: cost optimize, sporadic EC2, predictable Fargate/Lambda | S: Spot for EC2 + 1yr Compute Savings Plan for Fargate/Lambda |
| Q: 141 | E: global news/weather portal | P: lowest latency for all users | S: multi-region stack + Route 53 latency routing |
| Q: 142 | E: gaming app, UDP, low latency | P: nearest edge, static IPs | S: Global Accelerator + NLB + EC2 ASG |
| Q: 143 | E: migrate monolith, keep code | P: break into smaller apps, scalable, low overhead | S: ECS + ALB |
| Q: 144 | E: Aurora DB, poor perf on reports | P: cost-effective solution | S: move reporting to Aurora Replica |
| Q: 145 | E: analytics app on EC2, PHP/MySQL | P: scale seamlessly, cost-effective | S: Aurora MySQL + ASG with Spot + ALB |
| Q: 146 | E: stateless web app, variable usage | P: minimize EC2 cost, keep availability | S: Reserved for baseline + Spot for spikes |
| Q: 147 | E: app logs, 10yr retention, 10TB/mo | P: access 1mo, archive rest, cost-effective | S: S3 + Lifecycle to Glacier Deep Archive |
| Q: 148 | E: SNS + Lambda ingestion fails | P: ensure all notifications processed | S: SQS queue as DLQ, Lambda processes queue |
| Q: 149 | E: ordered event data | P: maintain order, min overhead | S: SQS FIFO queue + Lambda |
| Q: 150 | E: EC2 metric alarms, reduce false | P: act if CPU >50% & IOPS high | S: CloudWatch composite alarms |
