using System.Security.Cryptography.X509Certificates;
using inheritance.models;

namespace inheritance.services {
    public class GeneralPolicyInfoRetriever {
        public GeneralPolicyInfo GetGeneralPolicyInfo() {
           public virtual GeneralPolicyInfo GetGeneralPolicyInfo(string policyNumber) {
            
            return new GeneralPolicyInfo {
                PolicyNumber = "policyNumber",
                TermLengthInMonths = 12,
                PolicyHolder = "John Doe"
                };
            }
        }

        public decimal GetPolicyPremium(string policyNumber) {
            return 1000.00m;
        }
    }
}