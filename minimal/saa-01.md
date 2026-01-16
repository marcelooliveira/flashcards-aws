| Q | E | P | S |
|---|---|---|---|
| Q: 1 | E: collect global site data | P: aggregate quickly in S3, minimize complexity | S: S3 Transfer Acceleration, multipart upload |
| Q: 2 | E: analyze JSON logs in S3 | P: simple, on-demand queries, least overhead | S: Athena query S3 |
| Q: 3 | E: limit S3 access to Org users | P: simplest solution | S: aws:PrincipalOrgID in bucket policy |
| Q: 4 | E: EC2 needs private S3 access | P: best solution | S: gateway VPC endpoint for S3 |
| Q: 5 | E: users see docs on 2 EC2 | P: shared access to all docs | S: EFS shared file system |
| Q: 6 | E: migrate 70TB video to S3 | P: minimal network bandwidth | S: Snowball Edge offline transfer |
| Q: 7 | E: decouple message processing | P: handle 100k msg/sec spikes | S: SNS + SQS subscriptions |
| Q: 8 | E: modernize distributed app | P: max resiliency, scalability | S: SQS for jobs + EC2 Auto Scaling |
| Q: 9 | E: manage SMB file server storage | P: automate file lifecycle | S: S3 File Gateway + lifecycle to Glacier |
| Q: 10 | E: process ecommerce orders | P: preserve order | S: SQS FIFO queue + Lambda |
| Q: 11 | E: EC2 app uses Aurora DB | P: minimize credential management overhead | S: Secrets Manager + IAM role, auto rotation |
| Q: 12 | E: web app on EC2/ALB, static in S3 | P: improve performance, reduce latency | S: CloudFront with S3 + ALB origins, Route 53 |
| Q: 13 | E: rotate RDS MySQL creds multi-Region | P: least operational overhead | S: Secrets Manager, multi-Region replication, auto rotation |
| Q: 14 | E: ecommerce app, MySQL on EC2 | P: auto scale DB for unpredictable reads, high availability | S: Aurora Multi-AZ + Aurora Replicas, auto scaling |
| Q: 15 | E: protect VPC traffic | P: inspection/filtering like on-prem | S: AWS Network Firewall |
| Q: 16 | E: data lake in S3/RDS | P: reporting, visualization, access control | S: QuickSight analysis, dashboards, user sharing |
| Q: 17 | E: EC2 app needs S3 access | P: secure access | S: IAM role attached to EC2 |
| Q: 18 | E: microservice compresses images | P: durable, stateless, auto process | S: SQS queue + S3 notification + EventBridge trigger Lambda |
| Q: 19 | E: 3-tier app, traffic inspection | P: inspect before web server, least overhead | S: Gateway Load Balancer + endpoint to appliance |
| Q: 20 | E: clone prod EBS data to test | P: minimize clone time, high I/O | S: EBS fast snapshot restore |
| Q: 21 | E: one-deal-a-day site | P: handle millions req/hr, ms latency, least overhead | S: S3 + CloudFront + API Gateway + Lambda + DynamoDB |
| Q: 22 | E: store media files in S3 | P: resilient to AZ loss, optimize cost | S: S3 Intelligent-Tiering |
| Q: 23 | E: backup files in S3 | P: frequent access 1mo, keep indefinitely, cost-effective | S: Lifecycle to Glacier Deep Archive after 1mo |
| Q: 24 | E: analyze EC2 cost increase | P: compare 2mo, find vertical scaling cause | S: Cost Explorer granular filtering |
| Q: 25 | E: Lambda/API Gateway to Aurora | P: improve scalability, minimize config | S: 2 Lambdas + SQS integration |
| Q: 26 | E: review S3 config changes | P: prevent unauthorized changes | S: AWS Config with rules |
| Q: 27 | E: share CloudWatch dashboard | P: least privilege, no AWS account | S: CloudWatch shareable link by email |
| Q: 28 | E: SSO for multi-account AWS Org | P: keep on-prem AD user/group mgmt | S: AWS SSO + Directory Service, trust to AD |
| Q: 29 | E: VoIP service, UDP, multi-Region | P: route to lowest latency, auto failover | S: NLB + Global Accelerator endpoint per Region |
| Q: 30 | E: monthly RDS tests, 48h/mo | P: reduce cost, keep compute/mem | S: snapshot, terminate, restore as needed |
| Q: 31 | E: tag EC2/RDS/Redshift | P: minimize effort for compliance | S: AWS Config rules for tagging |
| Q: 32 | E: host static website | P: most cost-effective | S: S3 static website hosting |
| Q: 33 | E: marketplace app, share transactions | P: scalable, near-real-time, remove sensitive data | S: Kinesis Data Streams + Lambda + DynamoDB |
| Q: 34 | E: track config/API history | P: compliance, auditing, security | S: AWS Config + CloudTrail |
| Q: 35 | E: public web app, DDoS protection | P: detect/protect large-scale attacks | S: AWS Shield Advanced on ELB |
| Q: 36 | E: compliance monitoring | P: track config changes | S: AWS Config |
| Q: 37 | E: remote EC2 access strategy | P: repeatable, secure, least overhead | S: IAM role + Systems Manager Session Manager |
| Q: 38 | E: S3 static site, global demand | P: decrease latency, cost-effective | S: CloudFront in front of S3, Route 53 |
| Q: 39 | E: RDS MySQL, slow inserts | P: storage performance issue | S: Provisioned IOPS SSD |
| Q: 40 | E: edge devices generate alerts | P: ingest/store, 14d analysis, archive after | S: Kinesis Firehose to S3 + Lifecycle to Glacier |
| Q: 41 | E: EC2 app integrates SaaS, uploads to S3 | P: improve performance, least overhead | S: AppFlow for transfer + S3 event to SNS |
| Q: 42 | E: image app EC2 in VPC, S3 via NAT | P: avoid Regional data transfer charges | S: gateway VPC endpoint for S3 |
| Q: 43 | E: on-prem app, S3 backup, bandwidth limits | P: timely backup, minimal user impact | S: Direct Connect for backup traffic |
| Q: 44 | E: S3 bucket with critical data | P: protect from accidental deletion | S: versioning + MFA Delete |
| Q: 45 | E: data ingestion with SNS/Lambda | P: ingestion fails on network issues | S: SQS queue subscribed to SNS + Lambda reads SQS |
| Q: 46 | E: SFTP uploads, PII detection | P: alert/admin/remediation, least dev effort | S: S3 + Macie scan + SNS notification |
| Q: 47 | E: guarantee EC2 capacity in 3 AZs | P: for 1 week event | S: On-Demand Capacity Reservation |
| Q: 48 | E: website catalog on EC2 store | P: high availability, durability | S: move to EFS file system |
| Q: 49 | E: call transcripts, random access <1yr | P: optimize cost, fast recent, slow old | S: S3 Intelligent-Tiering + Lifecycle to Glacier Flexible Retrieval |
| Q: 50 | E: patch 1000 EC2 Linux, 3rd-party SW | P: remediate critical vulnerability quickly | S: Systems Manager Run Command |
