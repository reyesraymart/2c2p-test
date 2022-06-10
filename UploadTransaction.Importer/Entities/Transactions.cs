using System.Xml.Serialization;

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Transactions {
    
    private TransactionsTransaction[] itemsField;
    
    [System.Xml.Serialization.XmlElementAttribute("Transaction", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TransactionsTransaction[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TransactionsTransaction {
    
    private string transactionDateField;
    
    private string statusField;
    
    private TransactionsTransactionPaymentDetails[] paymentDetailsField;
    
    private string idField;

    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string TransactionDate {
        get {
            return this.transactionDateField;
        }
        set {
            this.transactionDateField = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Status {
        get {
            return this.statusField;
        }
        set {
            this.statusField = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute("PaymentDetails", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public TransactionsTransactionPaymentDetails[] PaymentDetails {
        get {
            return this.paymentDetailsField;
        }
        set {
            this.paymentDetailsField = value;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string id {
        get {
            return this.idField;
        }
        set {
            this.idField = value;
        }
    }
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class TransactionsTransactionPaymentDetails {
    
    private string amountField;
    
    private string currencyCodeField;
    
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string Amount {
        get {
            return this.amountField;
        }
        set {
            this.amountField = value;
        }
    }
    
    [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
    public string CurrencyCode {
        get {
            return this.currencyCodeField;
        }
        set {
            this.currencyCodeField = value;
        }
    }
}
