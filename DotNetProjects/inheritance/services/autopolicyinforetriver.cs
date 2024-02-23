using inheritance.models;

namespace inheritance.services {
    public class AutoPolicyInfoRetriever : GeneralPolicyInfoRetriever {
        public List<string> GetDrivers(string policyNumber) {
            return ["Me", "Her"];
        }
        
        
    }
}