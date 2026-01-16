# SAA-07: Resumo Condensado das Questões

| Q   | E   | P   | S   |
|-----|-----|-----|-----|
|301  | Migrar 30TB de Windows FS para FSx, rede compartilhada, controlar banda | AWS DataSync | DataSync gerencia migração e banda |
|302  | App móvel streaming vídeo, arquivos grandes, problemas de buffer | CloudFront + Elastic Transcoder | CDN + transcodificação otimizam streaming |
|303  | DR multi-região para MySQL em EC2 privado | Application Auto Scaling com CloudWatch | Auto Scaling ajusta tarefas ECS por métrica |
|304  | Migrar MySQL on-premises, acesso infrequente, sem downtime | AWS DataSync | DataSync transfere dados gerenciado |
|305  | Storage compartilhado para app de jogos, acesso SMB, gerenciado | FSx for Windows File Server | FSx suporta SMB, gerenciado |
|306  | S3 com documentos confidenciais, evitar deleção acidental | Habilitar versionamento e políticas restritivas | Versionamento protege contra deleção |
|307  | API Gateway com domínio próprio e HTTPS | Configurar domínio customizado e ACM | ACM fornece certificado SSL para API |
|308  | Otimizar custos RDS Oracle On-Demand, Trusted Advisor | Usar conta de billing consolidada + revisar RI | Billing consolidado + RI otimiza custos |
|309  | Identificar buckets S3 não acessados, menor overhead | S3 Storage Lens | Storage Lens analisa padrões de acesso |
|310  | Vender datasets grandes em S3, clientes globais, reduzir custo | CloudFront + URLs assinadas | CDN reduz custo e melhora performance |
|311  | Processar cotações separadas, garantir resposta e eficiência | SQS separado por tipo + Lambda | SQS + Lambda garante separação e eficiência |
|312  | Backup automatizado de EC2/EBS, mudar família/size em 6 meses | AWS Backup | Backup automatizado e centralizado |
|313  | App móvel streaming para milhões, acesso autorizado | CloudFront + URLs assinadas | CDN + URLs seguras para streaming |
|314  | Migrar MySQL on-premises, acesso infrequente, escalar fácil | Aurora Serverless | Aurora Serverless autoescala |
|315  | Scan de vulnerabilidades em EC2, relatório | Amazon Inspector | Inspector escaneia e gera relatório |
|316  | Reduzir custo de processamento SQS, escalar | Migrar script EC2 para Lambda | Lambda escala e reduz custo |
|317  | CSV legado em S3, COTS precisa Redshift | Glue ETL para Redshift | Glue automatiza ETL para Redshift |
|318  | Auditar mudanças em EC2 e SG | CloudTrail + AWS Config | Ambos auditam inventário e mudanças |
|319  | Remover chaves SSH compartilhadas em EC2 | Systems Manager Session Manager | Session Manager acessa sem SSH |
|320  | Ingestão JSON em EC2, consulta quase real-time | Kinesis Data Streams + Analytics | Kinesis processa e consulta em tempo real |
|321  | Garantir objetos S3 criptografados | Bucket policy nega sem x-amz-server-side-encryption | Política força criptografia |
|322  | Upload de imagens, thumbnail demorado, resposta rápida | SQS para thumbnail assíncrono | SQS desacopla processamento |
|323  | Processar mensagens de sensores de acesso, alta disponibilidade | API Gateway + Lambda + DynamoDB | Serverless, alta disponibilidade |
|324  | Restrição de acesso web, autenticação <100 usuários, escalar | Cognito + Lambda@Edge + CloudFront | Serverless, autenticação global |
|325  | App S3 + Cognito, erro de acesso protegido | Cognito assume IAM role correta | Role garante acesso seguro |
|326  | S3 assets grandes, acesso inconsistente, otimizar custo | Intelligent-Tiering + Lifecycle para multipart | Tiering + lifecycle otimizam custo |
|327  | EC2 privado, acesso só a repositórios aprovados | Network Firewall com regras de domínio | Firewall filtra por FQDN |
|328  | Web app 3 camadas, pico de vendas | CloudFront + Auto Scaling + SQS | CDN, escalabilidade e desacoplamento |
|329  | Patch e scan regular em EC2 | Inspector + Patch Manager | Automatiza scan e patch |
|330  | RDS precisa criptografia em repouso | KMS + habilitar criptografia | KMS gerencia chaves |
|331  | Migrar 20TB, banda limitada, 30 dias | AWS Snowball | Snowball transfere offline |
|332  | Acesso seguro a arquivos confidenciais, remoto | FSx integrado ao AD + Client VPN | FSx + VPN garante acesso seguro |
|333  | App lento em pico mensal, CPU 100% | Auto Scaling com scaling agendado | Escala antes do pico |
|334  | Cliente usa AD on-premises para baixar S3 via SFTP | AWS Transfer Family com AD | Transfer Family integra SFTP e AD |
|335  | Provisionar EC2 rápido de AMI, alta demanda | EBS Fast Snapshot Restore | FSR elimina latência de inicialização |
|336  | Aurora MySQL, credenciais criptografadas e rotacionadas | Secrets Manager + KMS, rotação 14 dias | Secrets Manager automatiza rotação |
|337  | RDS MySQL com réplicas, lag alto | Migrar para Aurora + Aurora Replicas | Aurora reduz lag de réplica |
|338  | DR Aurora MySQL multi-região | Aurora Global Database | Replicação eficiente e gerenciada |
|339  | App com credenciais embutidas, mais seguro | Secrets Manager para credenciais | Remove hardcode e rotaciona |
|340  | Web app vulnerável a SQLi | AWS WAF com ACL | WAF bloqueia SQL injection |
|341  | QuickSight + Lake Formation, restrição por coluna | Athena + registrar Aurora no Lake Formation | Permissão centralizada por coluna |
|342  | EC2 Auto Scaling para batch semanal, prever capacidade | Predictive Scaling | ML prevê e escala antes do pico |
|343  | DR multi-região para MySQL em EC2 | Aurora Global Database | DR gerenciado, baixo overhead |
|344  | SQS precisa processar mensagens >256KB | SQS Extended Client Library para S3 | Biblioteca gerencia payload grande |
|345  | Restrição de acesso web, autenticação <100 usuários, escalar | Cognito + Lambda@Edge + CloudFront | Serverless, autenticação global |
|346  | Migrar NAS SMB/NFS para S3, manter acesso | S3 File Gateway | Gateway mantém acesso SMB/NFS |
|347  | EC2, mudar família/size em 6 meses, economizar | Compute Savings Plan | Flexível e econômico |
|348  | DynamoDB, carga previsível, economizar | Provisioned mode | Provisionado é mais barato |
|349  | Compartilhar snapshot Aurora PostgreSQL criptografado | Adicionar conta à policy KMS + compartilhar snapshot | Policy KMS + snapshot compartilhado |
|350  | RDS SQL Server, alta disponibilidade, relatórios lentos | Multi-AZ + Read Replica | HA + replica para relatórios |
