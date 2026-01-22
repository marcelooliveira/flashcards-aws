# Decision trees - AWS Services

1. Analíticos: Onde os dados ganham vida

```mermaid
graph TD
    A[Precisa Analisar Dados?] --> B{Onde o dado está?}
    B -- No S3 - SQL Puro --> C[Amazon Athena]
    B -- Em um Cluster Big Data --> D[Amazon EMR - Spark/Hadoop]
    B -- No Data Warehouse --> E[Amazon Redshift]
    B -- Fluxo em Tempo Real --> F[Amazon Kinesis]
    B -- Stream do Kafka --> G[Amazon MSK]
    B -- Logs e Buscas --> H[OpenSearch Service]
    B -- Preciso comprar dados --> I[AWS Data Exchange]
    B -- Preciso de Dashboards --> J[Amazon QuickSight]
    B -- Organizar o Lago --> K[Lake Formation / Glue]
```

2. Integração: O diálogo dos sistemas

```mermaid
graph TD
    A[Precisa Integrar?] --> B{Qual o estilo?}
    B -- Disparar Eventos --> C[EventBridge]
    B -- Fila assíncrona 1:1 --> D[Amazon SQS]
    B -- Notificação 1:Muitos --> E[Amazon SNS]
    B -- Fluxo de Trabalho/Orquestração --> F[Step Functions]
    B -- API Moderna GraphQL --> G[AppSync]
    B -- Dados de Apps SaaS --> H[AppFlow]
    B -- Protocolo Antigo - MQ --> I[Amazon MQ]
```

3. Computação: O motor da nuvem

```mermaid
graph TD
    A[Onde rodar o código?] --> B{Qual o cenário?}
    B -- Servidor Virtual Puro --> C[Amazon EC2]
    B -- Subir App sem gerenciar infra --> D[Elastic Beanstalk]
    B -- Tarefas em Lote - Batch --> E[AWS Batch]
    B -- Local / On-premise --> F[AWS Outposts / VMware Cloud]
    B -- Baixa Latência 5G --> G[AWS Wavelength]
    B -- Escalar instâncias --> H[EC2 Auto Scaling]
```

4. Contêineres: A caixa mágica

```mermaid
graph TD
    A[Vai usar Contêiner?] --> B{Qual Orquestrador?}
    B -- Simples e Nativo AWS --> C[Amazon ECS]
    B -- Padrão Kubernetes --> D[Amazon EKS]
    B -- Fora da AWS - No seu Ferro --> E[ECS/EKS Anywhere]
    B -- Onde guardar a Imagem? --> F[Amazon ECR]
```

5. Bancos: O cofre do conhecimento

```mermaid
graph TD
    A[Onde salvar o dado?] --> B{Qual o formato?}
    B -- Relacional - SQL --> C{Qual escala?}
    C -- Padrão --> D[Amazon RDS]
    C -- Alta Performance/Serverless --> E[Amazon Aurora]
    B -- NoSQL - Chave/Valor --> F[DynamoDB]
    B -- Documentos JSON --> G[DocumentDB]
    B -- Memória / Cache --> H[ElastiCache]
    B -- Conexões / Redes --> I[Neptune]
    B -- Histórico Imutável --> J[QLDB]
```

6. Front e Mídia: A cara do sistema

```mermaid
graph TD
    A[Front e Mídia] --> B{Qual a tarefa?}
    B -- Web/Mobile Completo --> C[AWS Amplify]
    B -- Porta de entrada API --> D[API Gateway]
    B -- Engajamento/Marketing --> E[Amazon Pinpoint]
    B -- Testar em celulares reais --> F[Device Farm]
    B -- Converter vídeo --> G[Elastic Transcoder]
    B -- Stream de vídeo ao vivo --> H[Kinesis Video Streams]
```

7. Machine Learning: O robô sabido

```mermaid
graph TD
    A[Machine Learning] --> B{Precisa treinar o modelo?}
    B -- Sim - Do zero --> C[SageMaker]
    B -- Não - Usar API Pronta --> D{Qual a entrada?}
    D -- Texto/Sentimento --> E[Comprehend]
    D -- Voz para Texto --> F[Transcribe]
    D -- Texto para Voz --> G[Polly]
    D -- Visão Computacional --> H[Rekognition]
    D -- Chatbot --> I[Lex]
    D -- Documentos/OCR --> J[Textract]
```

8. Gerenciamento e Migração: Ordem na casa

```mermaid
graph TD
    A[Gestão e Migração] --> B{Qual o foco?}
    B -- Monitoria e Logs --> C[CloudWatch / CloudTrail]
    B -- Infra como Código --> D[CloudFormation]
    B -- Múltiplas Contas --> E[Organizations / Control Tower]
    B -- Migrar Servidor --> F[Application Migration Service]
    B -- Migrar Banco --> G[DMS]
    B -- Grandes volumes físicos --> H[Família Snow]
```

9. Redes e Segurança: O muro e a estrada

```mermaid
graph TD
    A[Redes e Segurança] --> B{O que proteger/conectar?}
    B -- Sua rede privada --> C[VPC]
    B -- Quem pode acessar o quê? --> D[IAM]
    B -- Ataques Web/DDoS --> E[WAF / Shield]
    B -- Conectar On-premise --> F[VPN / Direct Connect]
    B -- Gerenciar Chaves --> G[KMS / CloudHSM]
    B -- Acelerar entrega global --> H[CloudFront / Global Accelerator]
```

10. Armazenamento e Serverless: O celeiro e a leveza

```mermaid
graph TD
    A[Finalizando] --> B{Qual o destino?}
    B -- Arquivos/Objetos --> C[Amazon S3]
    B -- Disco de Instância --> D[Amazon EBS]
    B -- Arquivo compartilhado NFS --> E[Amazon EFS]
    B -- Rodar código sem servidor --> F[AWS Lambda]
    B -- Rodar contêiner sem servidor --> G[AWS Fargate]
```