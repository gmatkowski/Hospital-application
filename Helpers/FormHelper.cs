using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Helpers
{
    class FormHelper
    {
        public string ReplaceFieldnames(string message, Dictionary<string, string> replacers)
        {
            foreach (KeyValuePair<string, string> kvp in replacers)
            {
                message = message.Replace(kvp.Key, kvp.Value);
            }

            return message;
        }
    }
}
