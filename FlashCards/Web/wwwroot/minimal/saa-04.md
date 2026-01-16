| Q | E | P | S |
|---|---|---|---|
| Q: 151 | E: migrate on-premises to AWS, ap-northeast-3 | P: block VPC internet, restrict region | S: SCPs block internet + NACL outbound deny + restrict region |
| Q: 152 | E: 3-tier app, RDS MySQL | P: minimize DB cost, used 12h/day | S: Lambda + EventBridge to start/stop RDS |
| Q: 153 | E: S3 ringtones, millions files | P: save on storage, keep access for recent | S: Lifecycle to S3 Standard-IA after 90 days |
| Q: 154 | E: medical trial results in S3 | P: add-only, read-only, 1yr retention, no delete | S: S3 Object Lock compliance mode, 365 days |
| Q: 155 | E: cache confidential media files globally | P: fast access, reliable, access control | S: CloudFront + signed URLs/cookies |
| Q: 156 | E: batch + stream data, analytics | P: consolidate, process, stage in S3, BI | S: Kinesis Firehose to S3 + Athena + QuickSight |
| Q: 157 | E: Aurora PostgreSQL, 5yr retention | P: delete after 5yr, keep audit logs | S: AWS Backup lifecycle 5yr + CloudWatch Logs export |
| Q: 158 | E: musical event, video streaming | P: global audience, real-time + on-demand | S: CloudFront |
| Q: 159 | E: serverless app, API Gateway + Lambda | P: block botnets, unauthorized requests | S: API key usage plan + WAF rule |
| Q: 160 | E: analytics app, 300MB/mo JSON | P: DR backup, ms access, 30d retention, cost | S: S3 Standard |
| Q: 161 | E: Python app, process JSON, output to SQL | P: highly available, scalable, low overhead | S: S3 triggers Lambda, output to Aurora |
| Q: 162 | E: HPC for financial risk modeling | P: copy on-prem data, high perf, persistent, analytics | S: FSx for Lustre + S3 integration |
| Q: 163 | E: containerized app, thousands users | P: highly available, scale, low overhead | S: ECR + ECS Fargate + target tracking |
| Q: 164 | E: sender/processor apps, message retention | P: buffer, retain failed, up to 2 days | S: SQS queue + DLQ |
| Q: 165 | E: static website, S3 origin, security | P: inspect all traffic with WAF | S: CloudFront OAI + WAF on distribution |
| Q: 166 | E: global event, daily HTML reports | P: millions views, efficient | S: CloudFront with S3 origin |
| Q: 167 | E: EC2 app reads SQS, unpredictable traffic | P: continual process, no downtime, cost-effective | S: Reserved Instances for baseline + Spot for spikes |
| Q: 168 | E: limit service/action access in Org | P: scalable, single permission point | S: SCP in root OU |
| Q: 169 | E: public web app, ALB, security | P: reduce DDoS risk | S: Shield Advanced on ALB |
| Q: 170 | E: web app on EC2/ALB | P: restrict access to one country | S: WAF geo-match on ALB |
| Q: 171 | E: API for tax computation, holiday spikes | P: scalable, elastic | S: API Gateway + Lambda |
| Q: 172 | E: CloudFront, sensitive info, HTTPS | P: extra security, restrict access | S: CloudFront field-level encryption |
| Q: 173 | E: browser app, S3 media, millions users | P: reduce origin load, cost-effective | S: CloudFront web distribution |
| Q: 174 | E: multi-tier app, EC2 ASG, 1 AZ | P: high availability, no app change | S: ASG across 2 AZs |
| Q: 175 | E: order app, API Gateway + Lambda + Aurora | P: timeouts, high DB connections, min change | S: RDS Proxy for connection pool |
| Q: 176 | E: EC2 in private subnet, needs DynamoDB | P: secure, keep traffic in AWS | S: Gateway VPC Endpoint for DynamoDB |
| Q: 177 | E: DynamoDB, read intensive, delays | P: improve perf, no app change, low ops | S: DAX in-memory cache |
| Q: 178 | E: EC2 + RDS, backup to other region | P: least overhead | S: AWS Backup cross-region copy |
| Q: 179 | E: store DB creds for EC2 app | P: secure, use Parameter Store | S: IAM role with Parameter Store + KMS decrypt |
| Q: 180 | E: comms platform, EC2/NLB, API Gateway | P: block web exploits, DDoS | S: Shield Advanced on NLB + WAF on API Gateway |
| Q: 181 | E: legacy EC2 app, rewrite to microservices | P: decouple, scale, async | S: SQS queue for producer/consumer |
| Q: 182 | E: migrate MySQL, avoid outage/data loss | P: reliable, 2-node sync | S: RDS MySQL Multi-AZ |
| Q: 183 | E: dynamic ordering site, min maintenance | P: highly available, scale read/write | S: S3 static + API Gateway/Lambda + DynamoDB on-demand + CloudFront |
| Q: 184 | E: Lambda needs DB in on-prem subnet | P: access private DB via Direct Connect | S: Lambda in VPC with subnet/security group |
| Q: 185 | E: ECS app resizes images, stores in S3 | P: ensure S3 access | S: IAM role as taskRoleArn in ECS task |
| Q: 186 | E: Windows app, shared file system, multi-AZ | P: attach to EC2 Windows in multiple AZs | S: FSx for Windows File Server Multi-AZ |
| Q: 187 | E: ecommerce app, LB, container, DB | P: highly available, min manual | S: RDS Multi-AZ + ECS Fargate |
| Q: 188 | E: S3 data lake, partner uploads via SFTP | P: highly available, min ops | S: AWS Transfer Family SFTP server with S3 backend |
| Q: 189 | E: store contracts, 5yr, immutable, encrypt | P: no overwrite/delete, auto key rotation | S: S3 Object Lock compliance mode + KMS auto rotation |
| Q: 190 | E: Java/PHP web app, frequent tests | P: highly available, managed, min ops | S: Elastic Beanstalk + Blue/Green deployments |
