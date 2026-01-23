# Decision trees - AWS Services

1. Analíticos: Onde os dados ganham vida

```mermaid
graph LR
    A[Precisa Analisar Dados?] --> B{Onde o dado está?}
    B -- No S3 - SQL Puro --> C[Amazon Athena]
    C --> C1{Precisa de integração com BI?}
    C1 -- Sim --> C2[QuickSight]
    C1 -- Não --> C3[Exportar CSV]
    B -- Em um Cluster Big Data --> D[Amazon EMR - Spark/Hadoop]
    D --> D1{Framework?}
    D1 -- Spark --> D2[EMR Spark]
    D1 -- Hadoop --> D3[EMR Hadoop]
    D1 -- Presto --> D4[EMR Presto]
    B -- No Data Warehouse --> E[Amazon Redshift]
    E --> E1{Necessita ML integrado?}
    E1 -- Sim --> E2[Redshift ML]
    E1 -- Não --> E3[Redshift Spectrum]
    B -- Fluxo em Tempo Real --> F[Amazon Kinesis]
    F --> F1{Tipo de dado?}
    F1 -- Video --> F2[Kinesis Video Streams]
    F1 -- Dados Gerais --> F3[Kinesis Data Streams]
    F1 -- Analytics --> F4[Kinesis Data Analytics]
    B -- Stream do Kafka --> G[Amazon MSK]
    G --> G1{Gerenciado?}
    G1 -- Sim --> G2[MSK Serverless]
    G1 -- Não --> G3[MSK Cluster]
    B -- Logs e Buscas --> H[OpenSearch Service]
    H --> H1{Necessita Dashboards?}
    H1 -- Sim --> H2[Kibana]
    H1 -- Não --> H3[API Search]
    B -- Preciso comprar dados --> I[AWS Data Exchange]
    B -- Preciso de Dashboards --> J[Amazon QuickSight]
    J --> J1{Fonte de dados?}
    J1 -- S3 --> J2[QuickSight S3]
    J1 -- Redshift --> J3[QuickSight Redshift]
    B -- Organizar o Lago --> K[Lake Formation / Glue]
    K --> K1{ETL?}
    K1 -- Sim --> K2[Glue ETL]
    K1 -- Não --> K3[Lake Formation Catalog]
```

2. Integração: O diálogo dos sistemas

```mermaid
graph LR
    A[Precisa Integrar?] --> B{Qual o estilo?}
    B -- Disparar Eventos --> C[EventBridge]
    C --> C1{Necessita filtro avançado?}
    C1 -- Sim --> C2[EventBridge Rules]
    C1 -- Não --> C3[EventBridge padrão]
    B -- Fila assíncrona 1:1 --> D[Amazon SQS]
    D --> D1{Necessita FIFO?}
    D1 -- Sim --> D2[SQS FIFO]
    D1 -- Não --> D3[SQS Standard]
    B -- Notificação 1:Muitos --> E[Amazon SNS]
    E --> E1{Entrega SMS/Email?}
    E1 -- Sim --> E2[SNS SMS/Email]
    E1 -- Não --> E3[SNS HTTP]
    B -- Fluxo de Trabalho/Orquestração --> F[Step Functions]
    F --> F1{Express ou Standard?}
    F1 -- Express --> F2[Step Functions Express]
    F1 -- Standard --> F3[Step Functions Standard]
    B -- API Moderna GraphQL --> G[AppSync]
    G --> G1{Tempo real?}
    G1 -- Sim --> G2[AppSync Subscriptions]
    G1 -- Não --> G3[AppSync Queries]
    B -- Dados de Apps SaaS --> H[AppFlow]
    H --> H1{Fonte SaaS?}
    H1 -- Salesforce --> H2[AppFlow Salesforce]
    H1 -- Slack --> H3[AppFlow Slack]
    B -- Protocolo Antigo - MQ --> I[Amazon MQ]
    I --> I1{Protocolo?}
    I1 -- ActiveMQ --> I2[Amazon MQ ActiveMQ]
    I1 -- RabbitMQ --> I3[Amazon MQ RabbitMQ]
```

3. Computação: O motor da nuvem

```mermaid
graph LR
    A[Onde rodar o código?] --> B{Qual o cenário?}
    B -- Servidor Virtual Puro --> C[Amazon EC2]
    C --> C1{Tipo de instância?}
    C1 -- Spot --> C2[EC2 Spot]
    C1 -- Dedicada --> C3[EC2 Dedicated]
    C1 -- Normal --> C4[EC2 On-Demand]
    B -- Subir App sem gerenciar infra --> D[Elastic Beanstalk]
    D --> D1{Linguagem?}
    D1 -- .NET --> D2[Beanstalk .NET]
    D1 -- Node.js --> D3[Beanstalk Node]
    D1 -- Java --> D4[Beanstalk Java]
    B -- Tarefas em Lote - Batch --> E[AWS Batch]
    E --> E1{Ambiente gerenciado?}
    E1 -- Sim --> E2[Batch Managed]
    E1 -- Não --> E3[Batch Custom]
    B -- Local / On-premise --> F[AWS Outposts / VMware Cloud]
    F --> F1{Compatível VMware?}
    F1 -- Sim --> F2[VMware Cloud]
    F1 -- Não --> F3[AWS Outposts]
    B -- Baixa Latência 5G --> G[AWS Wavelength]
    B -- Escalar instâncias --> H[EC2 Auto Scaling]
    H --> H1{Tipo de scaling?}
    H1 -- Manual --> H2[Scaling Manual]
    H1 -- Dinâmico --> H3[Scaling Policies]
```

4. Contêineres: A caixa mágica

```mermaid
graph LR
    A[Vai usar Contêiner?] --> B{Qual Orquestrador?}
    B -- Simples e Nativo AWS --> C[Amazon ECS]
    C --> C1{Tipo de lançamento?}
    C1 -- EC2 --> C2[ECS on EC2]
    C1 -- Fargate --> C3[ECS on Fargate]
    B -- Padrão Kubernetes --> D[Amazon EKS]
    D --> D1{Gerenciado?}
    D1 -- Sim --> D2[EKS Gerenciado]
    D1 -- Não --> D3[EKS Anywhere]
    B -- Fora da AWS - No seu Ferro --> E[ECS/EKS Anywhere]
    B -- Onde guardar a Imagem? --> F[Amazon ECR]
    F --> F1{Tipo de imagem?}
    F1 -- Pública --> F2[ECR Public]
    F1 -- Privada --> F3[ECR Private]
```

5. Bancos: O cofre do conhecimento

```mermaid
graph TD
    A[Onde salvar o dado?] --> B{Qual o formato?}
    B -- Relacional - SQL --> C{Qual escala?}
    C -- Padrão --> D[Amazon RDS]
    D --> D1{Motor?}
    D1 -- MySQL --> D2[RDS MySQL]
    D1 -- PostgreSQL --> D3[RDS PostgreSQL]
    D1 -- SQL Server --> D4[RDS SQL Server]
    C -- Alta Performance/Serverless --> E[Amazon Aurora]
    E --> E1{Compatibilidade?}
    E1 -- MySQL --> E2[Aurora MySQL]
    E1 -- PostgreSQL --> E3[Aurora PostgreSQL]
    B -- NoSQL - Chave/Valor --> F[DynamoDB]
    F --> F1{Necessita Streams?}
    F1 -- Sim --> F2[DynamoDB Streams]
    F1 -- Não --> F3[DynamoDB Table]
    B -- Documentos JSON --> G[DocumentDB]
    B -- Memória / Cache --> H[ElastiCache]
    H --> H1{Engine?}
    H1 -- Redis --> H2[ElastiCache Redis]
    H1 -- Memcached --> H3[ElastiCache Memcached]
    B -- Conexões / Redes --> I[Neptune]
    B -- Histórico Imutável --> J[QLDB]
```

6. Front e Mídia: A cara do sistema

```mermaid
graph TD
    A[Front e Mídia] --> B{Qual a tarefa?}
    B -- Web/Mobile Completo --> C[AWS Amplify]
    C --> C1{Backend gerenciado?}
    C1 -- Sim --> C2[Amplify Backend]
    C1 -- Não --> C3[Amplify Frontend]
    B -- Porta de entrada API --> D[API Gateway]
    D --> D1{Tipo de API?}
    D1 -- REST --> D2[API Gateway REST]
    D1 -- WebSocket --> D3[API Gateway WebSocket]
    B -- Engajamento/Marketing --> E[Amazon Pinpoint]
    E --> E1{Canal?}
    E1 -- Email --> E2[Pinpoint Email]
    E1 -- SMS --> E3[Pinpoint SMS]
    B -- Testar em celulares reais --> F[Device Farm]
    B -- Converter vídeo --> G[Elastic Transcoder]
    G --> G1{Formato de saída?}
    G1 -- MP4 --> G2[Transcoder MP4]
    G1 -- HLS --> G3[Transcoder HLS]
    B -- Stream de vídeo ao vivo --> H[Kinesis Video Streams]
```

7. Machine Learning: O robô sabido

```mermaid
graph TD
    A[Machine Learning] --> B{Precisa treinar o modelo?}
    B -- Sim - Do zero --> C[SageMaker]
    C --> C1{Tipo de instância?}
    C1 -- Notebook --> C2[SageMaker Notebook]
    C1 -- Training --> C3[SageMaker Training]
    C1 -- Deploy --> C4[SageMaker Endpoint]
    B -- Não - Usar API Pronta --> D{Qual a entrada?}
    D -- Texto/Sentimento --> E[Comprehend]
    E --> E1{Idioma?}
    E1 -- Inglês --> E2[Comprehend EN]
    E1 -- Outro --> E3[Comprehend Multi]
    D -- Voz para Texto --> F[Transcribe]
    F --> F1{Idioma?}
    F1 -- Inglês --> F2[Transcribe EN]
    F1 -- Outro --> F3[Transcribe Multi]
    D -- Texto para Voz --> G[Polly]
    D -- Visão Computacional --> H[Rekognition]
    H --> H1{Tipo de análise?}
    H1 -- Imagem --> H2[Rekognition Image]
    H1 -- Vídeo --> H3[Rekognition Video]
    D -- Chatbot --> I[Lex]
    D -- Documentos/OCR --> J[Textract]
    J --> J1{Tipo de documento?}
    J1 -- Faturamento --> J2[Textract Invoice]
    J1 -- Outro --> J3[Textract General]
```

8. Gerenciamento e Migração: Ordem na casa

```mermaid
graph TD
    A[Gestão e Migração] --> B{Qual o foco?}
    B -- Monitoria e Logs --> C[CloudWatch / CloudTrail]
    C --> C1{Tipo de monitoria?}
    C1 -- Infra --> C2[CloudWatch Infra]
    C1 -- API --> C3[CloudTrail API]
    B -- Infra como Código --> D[CloudFormation]
    D --> D1{Necessita multi-conta?}
    D1 -- Sim --> D2[StackSets]
    D1 -- Não --> D3[Stack Único]
    B -- Múltiplas Contas --> E[Organizations / Control Tower]
    E --> E1{Governança?}
    E1 -- Sim --> E2[Control Tower]
    E1 -- Não --> E3[Organizations]
    B -- Migrar Servidor --> F[Application Migration Service]
    B -- Migrar Banco --> G[DMS]
    G --> G1{Tipo de banco?}
    G1 -- Homogêneo --> G2[DMS Homogeneous]
    G1 -- Heterogêneo --> G3[DMS Heterogeneous]
    B -- Grandes volumes físicos --> H[Família Snow]
    H --> H1{Tamanho?}
    H1 -- Pequeno --> H2[Snowcone]
    H1 -- Médio --> H3[Snowball]
    H1 -- Grande --> H4[Snowmobile]
```

9. Redes e Segurança: O muro e a estrada

```mermaid
graph TD
    A[Redes e Segurança] --> B{O que proteger/conectar?}
    B -- Sua rede privada --> C[VPC]
    C --> C1{Necessita NAT?}
    C1 -- Sim --> C2[VPC NAT Gateway]
    C1 -- Não --> C3[VPC padrão]
    B -- Quem pode acessar o quê? --> D[IAM]
    D --> D1{Tipo de acesso?}
    D1 -- Usuário --> D2[IAM User]
    D1 -- Role --> D3[IAM Role]
    D1 -- Policy --> D4[IAM Policy]
    B -- Ataques Web/DDoS --> E[WAF / Shield]
    E --> E1{Tipo de proteção?}
    E1 -- WAF --> E2[WAF]
    E1 -- Shield --> E3[Shield]
    B -- Conectar On-premise --> F[VPN / Direct Connect]
    F --> F1{Tipo de conexão?}
    F1 -- VPN --> F2[VPN Site-to-Site]
    F1 -- Direct Connect --> F3[Direct Connect]
    B -- Gerenciar Chaves --> G[KMS / CloudHSM]
    G --> G1{Tipo de chave?}
    G1 -- Gerenciada --> G2[KMS]
    G1 -- Dedicada --> G3[CloudHSM]
    B -- Acelerar entrega global --> H[CloudFront / Global Accelerator]
    H --> H1{Tipo de aceleração?}
    H1 -- CDN --> H2[CloudFront]
    H1 -- Network --> H3[Global Accelerator]
```

10. Armazenamento e Serverless: O celeiro e a leveza

```mermaid
graph TD
    A[Finalizando] --> B{Qual o destino?}
    B -- Arquivos/Objetos --> C[Amazon S3]
    C --> C1{Necessita versionamento?}
    C1 -- Sim --> C2[S3 Versioned]
    C1 -- Não --> C3[S3 Standard]
    B -- Disco de Instância --> D[Amazon EBS]
    D --> D1{Tipo de volume?}
    D1 -- SSD --> D2[EBS gp3]
    D1 -- HDD --> D3[EBS st1]
    B -- Arquivo compartilhado NFS --> E[Amazon EFS]
    E --> E1{Performance?}
    E1 -- Standard --> E2[EFS Standard]
    E1 -- Throughput --> E3[EFS MaxIO]
    B -- Rodar código sem servidor --> F[AWS Lambda]
    F --> F1{Trigger?}
    F1 -- API Gateway --> F2[Lambda API]
    F1 -- S3 Event --> F3[Lambda S3]
    B -- Rodar contêiner sem servidor --> G[AWS Fargate]
    G --> G1{Orquestrador?}
    G1 -- ECS --> G2[Fargate ECS]
    G1 -- EKS --> G3[Fargate EKS]
```