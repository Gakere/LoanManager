// <auto-generated />
namespace LoanManager.Migrations
{
    using System.CodeDom.Compiler;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Migrations.Infrastructure;
    using System.Resources;
    
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class MakeTransactionDebitAndCreditNonNullable : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(MakeTransactionDebitAndCreditNonNullable));
        
        string IMigrationMetadata.Id
        {
            get { return "201602271736270_MakeTransactionDebitAndCreditNonNullable"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}
