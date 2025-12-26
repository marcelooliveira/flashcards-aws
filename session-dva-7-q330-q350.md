# AWS Certification Training Session - DVA-7 (Q330-Q350)

**Data:** 23 de dezembro de 2025  
**Arquivo:** dva-7.yml  
**Questões:** 330-350

---

## Q330 - How should custom libraries be utilized in AWS Lambda?

### Conceitos Validados:

1. **ZIP file** ✅
   - In AWS Lambda, custom libraries are typically bundled into a **ZIP** file with your function code.

2. **Deployment package** ❌
   - A Lambda **deployment** package contains your function code and all its dependencies ready for deployment.

3. **Blueprints** ✅
   - AWS Lambda **blueprints** are pre-configured function templates that provide sample code for common use cases.

4. **Runtime** ✅
   - The Lambda **runtime** is the execution environment that runs your function code and includes the language-specific libraries and dependencies.

### Questão:

**How should custom libraries be utilized in AWS Lambda?**

A) Host the library on Amazon S3 and reference to it from the Lambda function.  
B) Install the library locally and upload a 'ZIP' file of the Lambda function. ✅  
C) Import the necessary Lambda blueprint when creating the function.  
D) Modify the function runtime to include the necessary library.

### Resposta: B ✅

**Explicação:**
- **Opção B (correta):** Instalar bibliotecas localmente e fazer upload em ZIP é o método recomendado - garante que todas as dependências estejam disponíveis
- **Opção A:** Lambda não busca bibliotecas do S3 automaticamente
- **Opção C:** Blueprints são templates iniciais, não mecanismos de distribuição
- **Opção D:** Runtimes são imutáveis e gerenciados pela AWS

---

## Q332 - Lambda deployment packages with dependencies

### Conceitos Validados:

1. **ZIP file** ✅
2. **Installed locally** ✅ (not just "included")
3. **buildspec.yaml** ❌
   - A **buildspec.yaml** file is used by AWS CodeBuild to define build steps, but it is not used by Lambda at runtime for dependency installation.
4. **Runtime environment** ❌
   - The Lambda **runtime** environment provides built-in language libraries, but custom libraries must be bundled separately.

### Questão:

**A Developer is writing an imaging micro service on AWS Lambda. The service is dependent on several libraries that are not available in the Lambda runtime environment. Which strategy should the Developer follow to create the Lambda deployment package?**

A) Create a 'ZIP' file with the source code and all dependent libraries. ✅  
B) Create a 'ZIP' file with the source code and a script that installs the dependent libraries at runtime.  
C) Create a 'ZIP' file with the source code. Stage the dependent libraries on an Amazon S3 bucket indicated by the Lambda environment variable 'LD_LIBRARY_PATH'  
D) Create a 'ZIP' file with the source code and a buildspec.yaml file that installs the dependent libraries on AWS Lambda.

### Resposta: A ✅

**Explicação:**
- **Opção A (correta):** Pacote pronto com código + bibliotecas instaladas
- **Opção B:** Lambda não instala pacotes em runtime (efêmero/read-only)
- **Opção C:** Lambda não carrega bibliotecas dinamicamente do S3
- **Opção D:** buildspec.yaml é para CodeBuild, não Lambda runtime

---

## Q334 - DynamoDB Streams for microservices data replication

### Conceitos Validados:

1. **DynamoDB Streams** ✅
   - Amazon DynamoDB **Streams** captures item-level changes in a table and enables near-real-time replication to other services.

2. **Decoupled architecture** ✅
   - In a microservices architecture, services should be **decoupled** to avoid direct dependencies on other services' data stores.

3. **Amazon Glue** ❌
   - Amazon **Glue** is a batch ETL service, not ideal for near-real-time data synchronization between microservices.

4. **Kinesis Data Firehose** ❌
   - Amazon Kinesis Data **Firehose** is designed for loading streaming data into data stores, not for capturing DynamoDB changes.

5. **Amazon ElastiCache** ✅
   - Amazon **ElastiCache** is an in-memory caching service, not a primary solution for database change propagation.

### Questão:

**In a move toward using microservices, a company's Management team has asked all Development teams to build their services so that API requests depend only on that service's data store. One team is building a Payments service which has its own database; the service needs data that originates in the Accounts database. Both are using Amazon DynamoDB. What approach will result in the simplest, decoupled, and reliable method to get near-real time updates from the Accounts database?**

A) Use Amazon Glue to perform frequent ETL updates from the Accounts database to the Payments database.  
B) Use Amazon ElastiCache in Payments, with the cache updated by triggers in the Accounts database.  
C) Use Amazon Kinesis Data Firehose to deliver all changes from the Accounts database to the Payments database.  
D) Use Amazon DynamoDB Streams to deliver all changes from the Accounts database to the Payments database. ✅

### Resposta: D ✅

**Explicação:**
- **Opção D (correta):** DynamoDB Streams captura mudanças em near-real time e mantém serviços decoupled
- **Opção A:** Glue é batch/ETL, não near-real time
- **Opção B:** ElastiCache + triggers é complexo e frágil
- **Opção C:** Firehose é para delivery a destinos, não captura de DynamoDB

---

## Q336 - Serverless Lambda scheduling

### Conceitos Validados:

1. **CloudWatch Events** ✅
   - Amazon CloudWatch **Events** can trigger Lambda functions on a schedule using cron or rate expressions.

2. **Serverless** ✅
   - A **serverless** application does not require managing servers like EC2 instances for scheduling tasks.

3. **Environment variables** ✅
   - Environment **variables** in Lambda can store configuration values, but they do not control function execution scheduling.

4. **SNS timer** ❌
   - Amazon SNS does not provide a built-in **timer** mechanism to trigger Lambda functions at fixed intervals.

### Questão:

**A Developer is writing a serverless application that requires that an AWS Lambda function be invoked every 10 minutes. What is an automated and serverless way to trigger the function?**

A) Deploy an Amazon EC2 instance based on Linux, and edit its '/etc/crontab' file by adding a command to periodically invoke the Lambda function.  
B) Configure an environment variable named PERIOD for the Lambda function. Set the value to '600'  
C) Create an Amazon CloudWatch Events rule that triggers on a regular schedule to invoke the Lambda function. ✅  
D) Create an Amazon SNS topic that has a subscription to the Lambda function with a 600-second timer.

### Resposta: C ✅

**Explicação:**
- **Opção C (correta):** CloudWatch Events (EventBridge) com `rate(10 minutes)` é totalmente serverless
- **Opção A:** EC2 + crontab não é serverless
- **Opção B:** Variáveis de ambiente não agendam execuções
- **Opção D:** SNS não tem funcionalidade de timer

---

## Q337 - DynamoDB Global Secondary Index for leaderboards

### Conceitos Validados:

1. **Partition key** ✅
   - A DynamoDB Global Secondary Index (GSI) allows you to query the table using a different **partition** key than the base table.

2. **Scan operation** ✅
   - A DynamoDB **scan** operation reads every item in the table, which is inefficient and expensive for large tables.

3. **Local Secondary Index** ✅
   - A Local Secondary Index (LSI) shares the same **partition** key as the base table but allows a different sort key.

4. **Sort key** ✅
   - In DynamoDB, a **sort** key determines how items are sorted within a partition, enabling efficient range queries.

### Questão:

**A company is building an application to track athlete performance using an Amazon DynamoDB table. Each item in the table is identified by a partition key ('user_id') and a sort key ('sport_name'). A Developer is asked to write a leaderboard application to display the top performers ('user_id') based on the score for each 'sport_name'. What process will allow the Developer to extract results MOST efficiently from the DynamoDB table?**

A) Use a DynamoDB query operation with the key attributes of 'user_id' and 'sport_name' and order the results based on the score attribute.  
B) Create a global secondary index with a partition key of 'sport_name' and a sort key of score, and get the results. ✅  
C) Use a DynamoDB scan operation to retrieve scores and 'user_id' based on 'sport_name', and order the results based on the score attribute.  
D) Create a local secondary index with a primary key of 'sport_name' and a sort key of score and get the results based on the score attribute.

### Resposta: B ✅

**Explicação:**
- **Opção B (correta):** GSI com PK=sport_name, SK=score permite queries eficientes por esporte ordenadas por pontuação
- **Opção A:** Query por user_id retorna apenas um usuário, não leaderboard
- **Opção C:** Scan é extremamente ineficiente
- **Opção D:** LSI não pode mudar partition key (mantém user_id)

---

## Q338 - Amazon Cognito unauthenticated identities

### Conceitos Validados:

1. **Identity pools** ✅
   - Amazon Cognito **identity** pools allow mobile apps to grant anonymous users temporary AWS credentials without requiring authentication.

2. **Unauthenticated identities** ✅
   - Amazon Cognito supports **unauthenticated** identities that receive temporary, limited-privilege AWS credentials without login.

3. **IAM users** ✅
   - Creating IAM **users** dynamically for each mobile user is inefficient and violates security best practices.

4. **KMS** ✅
   - AWS **KMS** manages encryption keys but is not used to create user credentials for application access.

### Questão:

**A Developer is creating a mobile application that will not require users to log in. What is the MOST efficient method to grant users access to AWS resources?**

A) Use an identity provider to securely authenticate with the application.  
B) Create an AWS Lambda function to create an IAM user when a user accesses the application.  
C) Create credentials using AWS KMS and apply these credentials to users when using the application.  
D) Use Amazon Cognito to associate unauthenticated users with an IAM role that has limited access to resources. ✅

### Resposta: D ✅

**Explicação:**
- **Opção D (correta):** Cognito identity pools com unauthenticated role = credenciais temporárias sem login
- **Opção A:** Identity provider requer autenticação
- **Opção B:** Criar IAM users dinamicamente é ineficiente e viola best practices
- **Opção C:** KMS gerencia chaves, não credenciais de usuário

---

## Q340 - SQS Delay Queue

### Conceitos Validados:

1. **Invisible/hidden** ✅
   - An SQS delay queue makes messages **invisible** for a configurable period after they are first added to the queue.

2. **Visibility timeout** ✅
   - SQS **visibility** timeout controls how long a message remains hidden after being consumed, not when first added.

3. **Long polling** ✅
   - SQS long **polling** allows consumers to wait for messages to arrive, reducing empty API calls.

### Questão:

**What does an Amazon SQS delay queue accomplish?**

A) Messages are hidden for a configurable amount of time when they are first added to the queue. ✅  
B) Messages are hidden for a configurable amount of time after they are consumed from the queue.  
C) The consumer can poll the queue for a configurable amount of time before retrieving a message.  
D) Message cannot be deleted for a configurable amount of time after they are consumed from the queue.

### Resposta: A ✅

**Explicação:**
- **Opção A (correta):** Delay queue esconde mensagens NOVAS por X segundos após serem adicionadas
- **Opção B:** Visibility timeout (após consumo)
- **Opção C:** Long polling (aguardar por mensagens)
- **Opção D:** Não é comportamento padrão do SQS

---

## Q341 - AWS CodeCommit for distributed development

### Conceitos Validados:

1. **CodeCommit** ✅
   - AWS **CodeCommit** is a managed Git service that supports distributed version control and efficient incremental code transfers.

2. **Distributed version control** ✅
   - Git supports **distributed** version control where developers can work offline and synchronize changes peer-to-peer.

3. **CodeBuild** ✅
   - AWS **CodeBuild** is a build service, not a version control system.

4. **CodeStar** ✅
   - AWS **CodeStar** is a project management service that bundles multiple development tools, not a source control system itself.

### Questão:

**A company has multiple Developers located across the globe who are updating code incrementally for a development project. When Developers upload code concurrently, internet connectivity is slow and it is taking a long time to upload code for deployment in AWS Elastic Beanstalk. Which step will result in minimized upload and deployment time with the LEAST amount of administrative effort?**

A) Allow the Developers to upload the code to an Amazon S3 bucket, and deploy it directly to Elastic Beanstalk.  
B) Allow the Developers to upload the code to a central FTP server to deploy the application to Elastic Beanstalk.  
C) Create an AWS CodeCommit repository, allow the Developers to commit code to it, and then directly deploy the code to Elastic Beanstalk. ✅  
D) Create a code repository on an Amazon EC2 instance so that all Developers can update the code, and deploy the application from the instance to Elastic Beanstalk.

### Resposta: C ✅

**Explicação:**
- **Opção C (correta):** CodeCommit = Git gerenciado com transferências incrementais eficientes + mínimo esforço administrativo
- **Opção A:** S3 requer upload de arquivos completos
- **Opção B:** FTP não é gerenciado, mais esforço administrativo
- **Opção D:** EC2 requer gerenciamento de instância

---

## Q342 - DynamoDB Accelerator (DAX)

### Conceitos Validados:

1. **DynamoDB Accelerator** ✅
   - Amazon DynamoDB **Accelerator** (DAX) is an in-memory cache designed specifically to accelerate DynamoDB read performance.

2. **Microsecond latency** ✅
   - DAX provides **microsecond** latency for cached DynamoDB read requests.

3. **Amazon EMR** ✅
   - Amazon **EMR** is a big data processing framework, not a caching solution for DynamoDB.

4. **CloudFront** ✅
   - Amazon **CloudFront** is a CDN for caching web content, not database read requests.

### Questão:

**A company recently migrated its web, application and NoSQL database tiers to AWS. The company is using Auto Scaling to scale the web and application tiers. More than 95 percent of the Amazon DynamoDB requests are repeated read requests. How can the DynamoDB NoSQL tier be scaled up to cache these repeated requests?**

A) Amazon EMR.  
B) Amazon DynamoDB Accelerator. ✅  
C) Amazon SQS.  
D) Amazon CloudFront.

### Resposta: B ✅

**Explicação:**
- **Opção B (correta):** DAX = cache in-memory específico para DynamoDB com latência de microsegundos
- **Opção A:** EMR é big data processing
- **Opção C:** SQS é mensageria
- **Opção D:** CloudFront é CDN para conteúdo web

---

## Q343 - Client-side encryption with KMS

### Conceitos Validados:

1. **Client-side encryption** ✅
   - **Client**-side encryption ensures data is encrypted on the client before transmission to S3, providing end-to-end protection.

2. **Server-side encryption at rest** ✅
   - S3 server-side encryption protects data at **rest**, but does not encrypt during transmission from the client.

3. **AWS KMS** ✅
   - AWS **KMS** manages encryption keys and logs all key usage for auditing purposes.

4. **Amazon Cognito authentication** ✅
   - Amazon Cognito handles user **authentication** and authorization, but does not provide encryption capabilities.

5. **Lambda attack surface** ✅
   - Using AWS Lambda to encrypt objects increases the **attack** surface compared to client-side encryption.

### Questão:

**A Development team is working on a case management solution that allows medical claims to be processed and reviewed. Users log in to provide information related to their medical and financial situations. As part of the application, sensitive documents such as medical records, medical imaging, bank statements, and receipts are uploaded to Amazon S3. All documents must be securely transmitted and stored. All access to the documents must be recorded for auditing. What is the MOST secure approach?**

A) Use S3 default encryption using Advanced Encryption Standard-256 (AES-256) on the destination bucket.  
B) Use Amazon Cognito for authorization and authentication to ensure the security of the application and documents.  
C) Use AWS Lambda to encrypt and decrypt objects as they are placed into the S3 bucket.  
D) Use client-side encryption/decryption with Amazon S3 and AWS KMS. ✅

### Resposta: D ✅

**Explicação:**
- **Opção D (correta):** Client-side encryption com KMS = proteção end-to-end + audit trail do KMS
- **Opção A:** SSE protege apenas at rest, não em trânsito
- **Opção B:** Cognito = autenticação, não criptografia
- **Opção C:** Lambda aumenta attack surface

---

## Q344 - STS temporary credentials and IAM principal

### Conceitos Validados:

1. **STS temporary credentials** ✅
   - AWS Security Token Service (STS) provides **temporary** credentials for accessing AWS resources.

2. **Web Identity Federation** ✅
   - Web Identity **Federation** allows users to authenticate using social identity providers like Facebook or Google.

3. **AccessKeyID** ✅
   - The STS response includes an **AccessKeyID** that identifies the IAM principal with specific permissions.

4. **IAM role** ✅
   - An IAM **role** defines a set of permissions that can be assumed temporarily by users or applications.

### Questão:

**A company has an internet-facing application that uses Web Identity Federation to obtain a temporary credential from AWS Security Token Service (AWS STS). The app then uses the token to access AWS services. Review the following response - Based on the response displayed what permissions are associated with the call from the application?**

A) Permissions associated with the role 'AROACLKWSDQRAOEXAMPLE:app1'  
B) Permissions associated with the default role used when the AWS service was built.  
C) Permission associated with the IAM principal that owns the 'AccessKeyID' 'ASgeIAIOSFODNN7EXAMPLE' ✅  
D) Permissions associated with the account that owns the AWS service.

### Resposta: C ✅

**Explicação:**
- **Opção C (correta):** As permissões são do IAM principal identificado pelo AccessKeyID nas credenciais
- **Opção A:** Role ARN é apenas identificador
- **Opção B:** Não existe "default role" automático
- **Opção D:** Não são permissões account-wide

---

## Q345 - AWS CLI Pagination

### Conceitos Validados:

1. **Pagination** ✅
   - AWS CLI **pagination** retrieves results in smaller chunks to prevent timeouts when listing large numbers of resources.

2. **Shorthand syntax** ✅
   - CLI shorthand **syntax** is a compact way to specify parameter values, but does not address timeout issues.

### Questão:

**A Developer is using AWS CLI, but when running list commands on a large number of resources, it is timing out. What can be done to avoid this time-out?**

A) Use pagination. ✅  
B) Use shorthand syntax.  
C) Use parameter values.  
D) Use quoting strings.

### Resposta: A ✅

**Explicação:**
- **Opção A (correta):** Pagination divide grandes resultados em chunks gerenciáveis (--max-items, --page-size)
- **Opção B:** Shorthand syntax é apenas formatação
- **Opção C/D:** Não resolvem timeout de grandes volumes

---

## Q346 - ECS Port Mappings in Task Definition

### Conceitos Validados:

1. **Port mappings** ✅
   - In Amazon ECS, container **port** mappings define how container ports map to host ports.

2. **Task definitions** ✅
   - ECS **task** definitions describe container configuration including port mappings, CPU, memory, and networking.

3. **Amazon ECR** ✅
   - Amazon **Elastic Container Registry** (ECR) is a container image registry, not where port mappings are configured.

4. **Security groups** ✅
   - Security **groups** control network traffic at the instance level, but do not define port mappings for containers.

### Questão:

**Where can PortMapping be defined when launching containers in Amazon ECS?**

A) Security groups.  
B) Amazon Elastic Container Registry (Amazon ECR).  
C) Container agent.  
D) Task definition. ✅

### Resposta: D ✅

**Explicação:**
- **Opção D (correta):** Task Definition (JSON) define portMappings: containerPort→hostPort
- **Opção A:** Security groups = firewall rules
- **Opção B:** ECR = registry de imagens
- **Opção C:** Container agent = executa tasks, não declara configurações

---

## Q347 - DynamoDB for metadata indexing

### Conceitos Validados:

1. **Millisecond latency** ✅
   - Amazon DynamoDB provides single-digit **millisecond** latency for key-value lookups.

2. **File metadata** ✅
   - DynamoDB is optimized for storing **file** metadata that requires fast retrieval, not the large files themselves.

3. **Amazon RDS** ✅
   - Amazon **RDS** is a relational database that typically has higher latency than DynamoDB for simple key-value lookups.

4. **AWS Lambda** ✅
   - AWS **Lambda** is a compute service for running code, not a database for storing and indexing metadata.

### Questão:

**An organization is storing large files in Amazon S3, and is writing a web application to display meta-data about the files to end-users. Based on the metadata a user selects an object to download. The organization needs a mechanism to index the files and provide single-digit millisecond latency retrieval for the metadata. What AWS service should be used to accomplish this?**

A) Amazon DynamoDB. ✅  
B) Amazon EC2.  
C) AWS Lambda.  
D) Amazon RDS.

### Resposta: A ✅

**Explicação:**
- **Opção A (correta):** DynamoDB = single-digit ms latency para key-value lookups (perfeito para metadata)
- **Opção B:** EC2 é compute, não database
- **Opção C:** Lambda é execução de código, não storage
- **Opção D:** RDS tem latência maior (~20-50ms)

---

## Q348 - CloudWatch Logs for application logging

### Conceitos Validados:

1. **CloudWatch Logs** ✅
   - Amazon CloudWatch **Logs** is designed to collect and centrally store application logs from EC2 and other AWS resources.

2. **VPC Flow Logs** ✅
   - VPC Flow **Logs** capture network traffic metadata, not application-level logs.

3. **AWS CloudTrail** ✅
   - AWS **CloudTrail** logs API calls for auditing and compliance, not application logs.

4. **Amazon CloudSearch** ✅
   - Amazon **CloudSearch** is a managed search service, not designed for storing application logs.

### Questão:

**While developing an application that runs on Amazon EC2 in an Amazon VPC, a Developer identifies the need for centralized storage of application-level logs. Which AWS service can be used to securely store these logs?**

A) Amazon EC2 VPC Flow Logs.  
B) Amazon CloudWatch Logs. ✅  
C) Amazon CloudSearch.  
D) AWS CloudTrail

### Resposta: B ✅

**Explicação:**
- **Opção B (correta):** CloudWatch Logs = storage centralizado para logs de aplicação
- **Opção A:** VPC Flow Logs = metadados de tráfego de rede
- **Opção C:** CloudSearch = search engine
- **Opção D:** CloudTrail = audit trail de API calls

---

## Q349 - Kinesis Producer Library (KPL)

### Conceitos Validados:

1. **Kinesis Producer Library** ✅
   - Kinesis Producer **Library** (KPL) optimizes batching and aggregation to improve throughput.

2. **Shards** ✅
   - Kinesis **shards** are the basic throughput units that determine stream capacity (1 shard = 1 MB/sec write, 2 MB/sec read).

3. **Retention period** ✅
   - Kinesis data **retention** period controls how long records are stored, not ingestion capacity.

4. **PutRecords API** ✅
   - The Kinesis **PutRecords** API allows sending multiple records in a single call to improve efficiency.

### Questão:

**A stock market monitoring application uses Amazon Kinesis for data ingestion. During simulated tests of peak data rates, the Kinesis stream cannot keep up with the incoming data. What step will allow Kinesis to accommodate the traffic during peak hours?**

A) Install the Kinesis Producer Library (KPL) for ingesting data into the stream. ✅  
B) Reduce the data retention period to allow for more data ingestion using 'DecreaseStreamRetentionPeriod'  
C) Increase the shard count of the stream using 'UpdateShardCount'  
D) Ingest multiple records into the stream in a single call using 'PutRecords'

### Resposta: A ✅

**Explicação:**
- **Opção A (correta):** KPL otimiza batching/aggregation automático para melhor throughput com mesmos shards
- **Opção B:** Retention ≠ ingestion capacity
- **Opção C:** Aumentar shards funciona, mas questão foca em eficiência do producer
- **Opção D:** PutRecords manual é menos otimizado que KPL

---

## Q350 - CloudFormation Nested Stacks

### Conceitos Validados:

1. **Nested stacks** ✅
   - CloudFormation **nested** stacks allow breaking large templates into reusable, modular components.

2. **Mappings** ✅
   - CloudFormation **mappings** provide key-value lookups for environment-specific values like AMI IDs per region.

3. **Embedded credentials** ✅
   - Embedding **credentials** in CloudFormation templates is a security risk and violates best practices.

4. **Nested stacks vs AWS::Include** ✅
   - AWS::Include is not a recommended best practice compared to using **nested** stacks for modularization.

### Questão:

**A company has an AWS CloudFormation template that is stored as a single file. The template is able to launch and create a full infrastructure stack. Which best practice would increase the maintainability of the template?**

A) Use nested stacks for common template patterns. ✅  
B) Embed credentials to prevent typos.  
C) Remove mappings to decrease the number of variables.  
D) Use 'AWS::Include' to reference publicly-hosted template files.

### Resposta: A ✅

**Explicação:**
- **Opção A (correta):** Nested stacks = modularização, reuso, melhor manutenibilidade (best practice)
- **Opção B:** Embed credentials = grave violação de segurança
- **Opção C:** Remover mappings reduz flexibilidade
- **Opção D:** Referenciar templates públicos não é best practice geral

---

## Resumo da Sessão

**Total de questões:** 21 (Q330-Q350)  
**Conceitos únicos validados:** 75+  
**Serviços AWS cobertos:**
- Lambda
- DynamoDB & DAX
- DynamoDB Streams
- CloudWatch Events/Logs
- S3 & KMS
- Cognito
- SQS
- CodeCommit
- ECS
- Kinesis
- CloudFormation
- STS

**Áreas de foco:**
- Serverless architectures
- Security best practices
- Microservices patterns
- Performance optimization
- Infrastructure as Code

---

**📌 Próximos passos:** Continue praticando com as questões seguintes do arquivo dva-7.yml para aprofundar seu conhecimento para a certificação AWS Developer Associate!
