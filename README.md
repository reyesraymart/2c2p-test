2C2P - Raymart
================

## About

Service to upload transaction data from csv or xml files into database and query transactions by specified criteria.

## Getting started

Update the MSSql connection string in the appsettings.Development.json
You can use the sample file in the folder SampleData

### Sample Input Data

Example:
```
"Invoice0000001","1,000.00","USD","20/02/2019 12:33:16","Approved"
"Invoice0000002","300.00","USD","21/02/2019 02:04:59","Failed"”
```

Example:
```
<Transactions>
    <Transaction id="Inv00001">
    <TransactionDate>2019-01-23T13:45:10</TransactionDate>
        <PaymentDetails>
            <Amount>200.00</Amount>
            <CurrencyCode>USD</CurrencyCode>
        </PaymentDetails>
        <Status>Done</Status>
    </Transaction>
    <Transaction id="Inv00002">
    <TransactionDate>2019-01-24T16:09:15</TransactionDate>
        <PaymentDetails>
            <Amount>10000.00</Amount>
            <CurrencyCode>EUR</CurrencyCode>
        </PaymentDetails>
        <Status>Rejected</Status>
    </Transaction>
</Transactions>
```

### Sample Output Data

Example of output:
```
[{ "id":"Inv00001", "payment":"200.00 USD", "Status": "D"},
 { "id":"Inv00002", "payment":"10000.00 EUR", "Status": "R"},
 { "id":"Invoice0000001", "payment":"1000.00 USD", "Status": "A"},
 { "id":"Invoice0000002", "payment":"300.00 USD", "Status": "R"}]
 ```# 2c2p-test
