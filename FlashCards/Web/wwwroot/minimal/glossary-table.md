| Serviço AWS / Opção / Conceito | Quando utilizar |
| :--- | :--- |
| **ALB (SSL Offloading)** | Para melhorar o desempenho do servidor web ao realizar a descriptografia SSL/TLS no balanceador de carga. |
| **ALB + Sticky Sessions** | Para aplicações web que precisam manter o estado da sessão do usuário no mesmo servidor de backend. |
| **ALB + WAF** | Para proteger aplicações web públicas contra ataques (SQLi, XSS) usando listas de controle de acesso à web integradas. |
| **Amazon Athena** | Para realizar consultas SQL ad-hoc diretamente em dados não estruturados (JSON, CSV) armazenados no S3. |
| **Amazon Aurora (Auto Scaling)** | Para adicionar ou remover réplicas de leitura automaticamente com base na demanda de tráfego. |
| **Amazon Aurora (Global Database)** | Para desastres com RTO baixo e replicação de dados entre regiões em menos de 1 segundo. |
| **Amazon Aurora (Read Replica Promotion)** | Para migrar do RDS PostgreSQL para o Aurora com tempo de inatividade e perda de dados mínimos. |
| **Amazon Aurora Serverless** | Para bancos de dados relacionais com padrões de uso altamente imprevisíveis ou esporádicos. |
| **Amazon Backup** | Para centralizar e automatizar a proteção de dados e a retenção de longo prazo (incluindo cópia entre regiões). |
| **Amazon CloudFront** | Para reduzir a latência global armazenando conteúdo em cache e protegendo o backend contra picos de tráfego. |
| **Amazon CloudFront (Geographic Restriction)** | Para impedir que usuários de países específicos acessem sua aplicação com base na localização do IP. |
| **Amazon CloudFront (OAC/OAI)** | Para restringir o acesso ao S3 para que os arquivos sejam visíveis apenas via CloudFront, não por URLs diretas. |
| **Amazon CloudFront (Signed URLs)** | Para distribuir conteúdo privado ou pago apenas para usuários autenticados com segurança. |
| **Amazon Cognito (Identity Pools)** | Para fornecer credenciais AWS temporárias a usuários autenticados para acesso direto a recursos como o S3. |
| **Amazon Data Lifecycle Manager (DLM)** | Para automatizar a criação e exclusão de snapshots do EBS com base em políticas de custo. |
| **Amazon DynamoDB (On-Demand)** | Para cargas de trabalho imprevisíveis onde se prefere pagar por requisição em vez de gerenciar unidades de capacidade. |
| **Amazon DynamoDB com DAX** | Quando a latência de leitura precisa cair de milissegundos para microssegundos. |
| **Amazon EFS** | Para sistemas de arquivos compartilhados que precisam ser montados simultaneamente por várias instâncias EC2. |
| **Amazon EFS (Standard-IA)** | Para reduzir custos movendo arquivos não acessados há 30 dias para uma classe de armazenamento mais barata. |
| **Amazon ElastiCache (Multi-AZ)** | Para fornecer um armazenamento de sessão gerenciado e altamente disponível para aplicações web. |
| **Amazon EMR (Spot Instances)** | Para processar grandes volumes de dados (Hadoop/Spark) com o menor custo possível. |
| **Amazon EMR (Transient Cluster)** | Para rodar jobs de Big Data que duram pouco tempo, desligando o cluster automaticamente ao finalizar. |
| **Amazon EventBridge** | Para arquiteturas orientadas a eventos que disparam funções Lambda com base em mudanças de estado de recursos. |
| **Amazon FSx for Lustre** | Para cargas de trabalho HPC (computação de alto desempenho) que exigem altíssimo throughput. |
| **Amazon FSx for NetApp ONTAP** | Quando é necessário um sistema que suporte nativamente protocolos NFS e SMB simultaneamente no mesmo volume. |
| **Amazon FSx for OpenZFS** | Para migrar sistemas ZFS locais para a nuvem mantendo alta performance e baixa latência. |
| **Amazon FSx for Windows (Multi-AZ)** | Para sistemas de arquivos compartilhados Windows altamente disponíveis que abrangem duas zonas de disponibilidade. |
| **Amazon GuardDuty** | Para detecção inteligente de ameaças e monitoramento contínuo de atividades maliciosas na conta. |
| **Amazon Inspector** | Para verificar automaticamente vulnerabilidades de software em instâncias EC2 e gerar relatórios de segurança. |
| **Amazon Kinesis Data Analytics** | Para realizar análises SQL em tempo real sobre fluxos de dados de streaming. |
| **Amazon Kinesis Data Firehose** | Para carregar dados de streaming quase em tempo real no S3, Redshift ou OpenSearch. |
| **Amazon Kinesis Data Streams** | Para ingerir e processar grandes fluxos de dados em tempo real com retenção configurável. |
| **Amazon Pinpoint** | Para gerenciar comunicações de marketing em duas vias (SMS/Email) e jornadas de engajamento do cliente. |
| **Amazon QuickSight** | Para criar dashboards interativos de BI (Business Intelligence) a partir de diversas fontes de dados. |
| **Amazon RDS (Multi-AZ)** | Para alta disponibilidade e durabilidade de dados através de replicação síncrona para um nó standby. |
| **Amazon RDS (Read Replicas)** | Para aliviar a carga de leitura do banco de dados principal, separando o tráfego de relatórios. |
| **Amazon RDS Custom** | Quando você precisa de um banco gerenciado, mas ainda exige acesso administrativo ao sistema operacional. |
| **Amazon RDS Proxy** | Para gerenciar pools de conexões e evitar a exaustão de conexões do banco de dados por funções Lambda. |
| **Amazon SES** | Para envio de e-mails transacionais ou de marketing em larga escala com baixo custo operacional. |
| **Amazon SNS + SQS (Fan-out)** | Para desacoplar microserviços e permitir que uma única mensagem dispare múltiplos processos paralelos. |
| **Amazon SQS (Dead-Letter Queue)** | Para isolar mensagens que falham no processamento para análise posterior sem bloquear a fila principal. |
| **Amazon SQS (Visibility Timeout)** | Para evitar que múltiplos consumidores processem a mesma mensagem simultaneamente. |
| **Amazon SQS FIFO** | Quando a ordem exata do processamento das mensagens é crítica e duplicatas não são permitidas. |
| **Amazon Transit Gateway** | Para atuar como um hub central conectando múltiplas VPCs e redes locais de forma escalável. |
| **aws:PrincipalOrgID** | Para restringir o acesso a recursos em políticas de bucket a apenas contas de uma Organização específica. |
| **AWS Application Discovery Service** | Para coletar informações técnicas de servidores locais e planejar a migração para a nuvem. |
| **AWS AppFlow** | Para automatizar transferências seguras de dados entre aplicações SaaS (como Salesforce) e serviços AWS. |
| **AWS Batch** | Para provisionar e escalonar instâncias EC2 automaticamente para trabalhos de processamento em lote. |
| **AWS Certificate Manager (ACM)** | Para provisionar e gerenciar certificados SSL/TLS para ALBs e CloudFront. |
| **AWS CloudFormation (Drift Detection)** | Para identificar recursos que foram alterados manualmente fora do template original do CloudFormation. |
| **AWS Config** | Para auditar, registrar e avaliar continuamente as alterações de configuração dos recursos para conformidade. |
| **AWS DataSync** | Para migrar grandes volumes de dados de storage local para S3 ou FSx com aceleração e controle de largura de banda. |
| **AWS Direct Connect** | Para fornecer uma conexão de rede dedicada e privada entre o data center local e a AWS. |
| **AWS DMS w/ Ongoing replication using Change Data Capture (CDC)** | keeps databases in sync by capturing and applying only new or changed data (inserts, updates, deletes) from a source to a target in near real-time, often after an initial full data load |
| **AWS Elastic Beanstalk** | Para migrar e testar aplicações Java/PHP rapidamente usando ambientes gerenciados e deploy Blue/Green. |
| **AWS Fargate** | Para rodar containers (ECS/EKS) de forma serveless, sem gerenciar os servidores ou instâncias EC2 subjacentes. |
| **AWS Global Accelerator** | Para otimizar o caminho de rede global usando IPs estáticos e a infraestrutura de rede privada da AWS. |
| **AWS Glue (ETL)** | Para transformar, limpar e converter formatos de dados (ex: CSV para Parquet) de forma serveless. |
| **AWS Glue Job Bookmarks** | To prevent reprocessing of old data in ETL jobs by tracking state and only processing new S3 objects. |
| **AWS Local Zones** | Para implantar aplicações que exigem latência de milissegundos de um dígito perto de usuários finais específicos. |
| **AWS Migration Hub** | Para rastrear centralmente o progresso das migrações de aplicativos entre várias ferramentas AWS. |
| **AWS Network Firewall** | Para inspeção profunda de pacotes (DPI) e filtragem de tráfego de entrada e saída da VPC. |
| **AWS Organizations (SCPs)** | Para restringir regiões e serviços centralmente em todas as contas de uma organização. |
| **AWS Outposts** | Para executar serviços AWS localmente no data center do cliente (nuvem híbrida). |
| **AWS PrivateLink** | Para conectar VPCs de forma privada e segura, mantendo o tráfego dentro da rede da AWS sem usar a internet. |
| **AWS Resource Access Manager (RAM)** | Para compartilhar recursos (como prefix lists ou subnets) entre múltiplas contas da mesma organização. |
| **AWS Schema Conversion Tool (SCT)** | conversão de schema entre bancos de dados |
| **AWS Secrets Manager** | Para armazenar e rotacionar automaticamente segredos e credenciais de bancos de dados. |
| **AWS Shield Advanced** | Para proteção contra ataques DDoS de larga escala com proteção de custo contra picos de faturamento. |
| **AWS Snowball Edge** | Para migrar petabytes de dados offline quando a largura de banda da rede é insuficiente. |
| **AWS Snowmobile** | Para transferir grandes volumes de dados em ambientes remotos ou desconectados usando dispositivos portáteis. |
| **AWS Step Functions** | Para orquestrar fluxos de trabalho serveless e gerenciar estados entre microserviços distribuídos. |
| **AWS Systems Manager (Patch Manager)** | Para automatizar o processo de aplicação de patches de segurança em uma frota de instâncias. |
| **AWS Systems Manager (Run Command)** | Para executar scripts ou comandos em massa em uma frota de instâncias sem acesso SSH direto. |
| **AWS Systems Manager (Session Manager)** | Para acessar instâncias via shell de forma segura e auditável sem necessidade de chaves SSH ou Bastion Hosts. |
| **AWS Transfer Family** | Para habilitar transferências de arquivos via SFTP/FTPS diretamente para o S3 ou EFS de forma gerenciada. |
| **AWS WAF** | Para proteger aplicações contra exploits comuns da web, como SQL Injection e Cross-Site Scripting (XSS). |
| **CloudWatch Composite Alarms** | Para reduzir o ruído de alertas, disparando notificações apenas quando várias condições (AND/OR) são atendidas. |
| **EBS Fast Snapshot Restore (FSR)** | Para inicializar volumes EBS a partir de snapshots com desempenho total imediato, sem latência de primeiro acesso. |
| **EBS gp3 Volumes** | Para provisionar IOPS e throughput independentemente do tamanho do disco, economizando custos em relação ao gp2/io1. |
| **EBS Multi-Attach** | Para permitir que um único volume Provisioned IOPS seja montado em várias instâncias EC2 na mesma zona. |
| **EC2 Auto Scaling (Predictive)** | Para aumentar a capacidade antecipadamente com base em padrões históricos de tráfego diário ou semanal. |
| **EC2 Auto Scaling (Scheduled)** | Para escalar a frota proativamente antes de picos de tráfego conhecidos (ex: início do horário comercial). |
| **EC2 Placement Group (Cluster)** | Para fornecer latência de rede ultrabaixa entre instâncias para cargas de trabalho HPC. |
| **EC2 Spot Instances** | Para cargas de trabalho flexíveis ou tolerantes a falhas (como processamento batch) com descontos de até 90%. |
| **Gateway Load Balancer (GWLB)** | Para implantar e gerenciar frotas de appliances virtuais de terceiros para inspeção de tráfego em linha. |
| **Gateway VPC Endpoint** | Para fornecer conectividade privada da VPC ao S3 ou DynamoDB sem passar pela internet. |
| **IAM Role for EC2** | Para conceder permissões temporárias e seguras às instâncias para acessar outros serviços AWS sem chaves estáticas. |
| **Lambda@Edge** | Para processar lógica de aplicação nas bordas do CloudFront (ex: redimensionar imagens ou verificar cabeçalhos). |
| **NAT Gateway** | Para permitir que instâncias em subnets privadas acessem a internet (outbound) para atualizações, bloqueando conexões de entrada. |
| **Network Load Balancer (NLB)** | Para lidar com milhões de requisições por segundo com latência ultrabaixa em tráfego TCP/UDP. |
| **Responsabilidade Compartilhada (AWS)** | Pela segurança física do data center, hardware e patching de hipervisores de serviços gerenciados. |
| **Responsabilidade Compartilhada (Cliente)** | Pela configuração de software em containers, gerenciamento de patches de OS em EC2 e criptografia de dados. |
| **Route 53 Geolocation Routing** | Para direcionar tráfego com base na localização geográfica do usuário. |
| **Route 53 Latency Routing** | Para direcionar usuários para a região AWS que oferece a menor latência de rede. |
| **Route 53 Multi-Value Answer** | Para retornar até 8 registros de IP saudáveis em uma única consulta DNS para balanceamento de carga simples. |
| **S3 Event Notifications** | allow you to trigger actions in other AWS services (like Lambda, SQS, SNS, or EventBridge) in response to specific object events in your S3 bucket, such as uploads, deletions, or restores, creating event-driven workflows without needing to poll for changes. |
| **S3 Glacier Deep Archive** | Para retenção de longo prazo (anos) com o menor custo e tempo de recuperação de 12 horas. |
| **S3 Glacier Flexible Retrieval** | Para arquivos que precisam de arquivamento barato, mas retriveal garantido entre 1 a 5 horas. |
| **S3 Glacier Instant Retrieval** | Para dados arquivados que raramente são acessados, mas que exigem acesso imediato (milissegundos) quando solicitados. |
| **S3 Intelligent-Tiering** | Para otimizar custos movendo objetos automaticamente entre tiers de acesso frequente e infrequente. |
| **S3 Lifecycle Policies** | Para automatizar a transição de dados para classes de armazenamento mais baratas ou exclusão após períodos definidos. |
| **S3 MFA Delete** | Para adicionar uma camada de segurança extra que exige autenticação multifator para excluir versões de objetos. |
| **S3 Object Lock (Compliance Mode)** | Para impedir estritamente que qualquer usuário (incluindo root) exclua objetos até que o período de retenção expire. |
| **S3 Object Lock (Governance Mode)** | Para impedir que usuários comuns excluam arquivos, mas permitir que usuários autorizados removam a proteção se necessário. |
| **S3 Object Lock (Legal Hold)** | Para manter objetos imutáveis por tempo indeterminado até que uma "trava legal" específica seja removida manualmente. |
| **S3 Transfer Acceleration** | Para acelerar uploads de longa distância para o S3 usando os pontos de presença da rede AWS (Edge Locations). |
| **Savings Plans** | Para reduzir custos de computação (EC2, Fargate, Lambda) em troca de um compromisso de uso por 1 ou 3 anos. |
| **Storage Gateway (File Gateway)** | Para conectar aplicações locais ao S3 via protocolos padrão de arquivos (NFS/SMB). |
| **Storage Gateway (Tape Gateway)** | Para substituir bibliotecas de fitas físicas locais por backups virtuais no S3 ou Glacier. |
| **VPC Peering** | Para conectar duas VPCs de forma econômica, permitindo comunicação interna usando endereços IP privados. |