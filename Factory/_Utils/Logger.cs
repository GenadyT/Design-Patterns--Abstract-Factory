using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Factory._Utils
{
    public class Logger
    {
		protected StringBuilder sb;
		public string Log
		{
			get { return sb.ToString(); }
		}

        private const string Boundary_Line = "+++++++++++++";

        public Logger()
		{
			sb = new StringBuilder();
		}

		public void StartLog(string startStr = "")
		{
            if (startStr != String.Empty) { sb.AppendLine(startStr); }
            sb.AppendLine(Boundary_Line);
        }

        public void EndLog(string endStr = "")
        {
            if (endStr != String.Empty) { sb.AppendLine(endStr); }
            sb.AppendLine(Boundary_Line);
        }

        public void Write(string logStr)
        {
            sb.Append(logStr);
        }

        public void WriteLine(string logStr)
		{
			sb.AppendLine(logStr);
		}

        public void WriteItemLine(string logStr)
        {
            sb.AppendLine($"  {logStr}");
        }

        protected const string Store_Header_Line = "*************************************";
        public void WriteStoreHeader(string storeName)
        {
            sb.Append('\n');
            sb.AppendLine(Store_Header_Line);
            sb.AppendLine($"Pizza Store ==> {storeName}");
            sb.AppendLine(Store_Header_Line);
            sb.Append('\n');
        }

        protected const string Pizza_Header_Line = "++++++++++++++";
        public void WritePizzaHeader(string pizzaName)
        {
            sb.Append('\n');
            sb.AppendLine($"Pizza => {pizzaName}");
            sb.AppendLine(Pizza_Header_Line);
            sb.Append('\n');
        }

        protected const string Pizza_Step_Line = "-----------";
        public void WritePizzaMakeStep(string stepName)
        {
            //sb.Append('\n');
            sb.AppendLine(Pizza_Step_Line);
            sb.AppendLine($"make step - {stepName}");
            sb.AppendLine(Pizza_Step_Line);
            //sb.Append('\n');
        }
    }
}
