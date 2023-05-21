namespace Variance
{
    class Testing
    {
        private IEnumerable<object> stringo = new List<string>(); //Covariance
        private List<string> buu = new List<string>();
        private IList<object> gop = new List<object>(); //just checking that the Add() is
                                                        //a quality of IList<T>

        // private delegate void foote(string k);

        public void JustTesting()
        {
            Action<object> hoo = (h) => {string r = h.GetType().Name + "k";};
            Action<string> gii = hoo; //Contravariance

            
        }
        
        
 
        

    }
}