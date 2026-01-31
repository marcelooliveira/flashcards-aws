### Acesso Cross-Account ao Amazon DynamoDB

Cross-account access ao Amazon DynamoDB é uma prática que permite que uma aplicação em uma conta AWS acesse tabelas DynamoDB localizadas em outras contas AWS. Isso é útil em cenários onde diferentes unidades de negócios ou equipes possuem suas próprias contas AWS, mas precisam compartilhar dados de forma segura e controlada.

```mermaid
flowchart TD
    subgraph AWSOrg["AWS Organization"]
        AccountShared["Shared Account<br/>Reporting App<br/>APP_ROLE"]
        BU1["Business Unit 1 Account<br/>DynamoDB Table 1<br/>BU_ROLE"]
        BU2["Business Unit 2 Account<br/>DynamoDB Table 2<br/>BU_ROLE"]
        BU3["Business Unit N Account<br/>DynamoDB Table N<br/>BU_ROLE"]
    end

    APP_ROLE -->|1. Assume BU_ROLE<br/>sts:AssumeRole<br/>Trust Policy permite Shared Acct| BU_ROLE
    BU_ROLE -->|2. Policy permite dynamodb:GetItem etc.<br/>Scoped ao Table local| DynamoDB["Read DynamoDB Tables<br/>Multi-account"]

    style AccountShared fill:#e1f5fe
    style BU1 fill:#f3e5f5
    style BU2 fill:#f3e5f5
    style BU3 fill:#f3e5f5
```

----
