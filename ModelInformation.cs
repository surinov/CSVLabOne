namespace CSVLabOne
{
    public class ModelInformation
    {
        public bool Check(int errros)
        {
            var result = errros == 0;

            return result;
        }

        public int SearchtArr(string[] a, string c)
        {
            var b = 0;
            for (var i = 0; i < 6; i ++ )
            {
                if (a[i] == c)
                {
                    b = i;
                }
            }

            return b;
        }

        public string[] AddElements(string[] a, string[] b)
        {
            for (var i = 0; i < 6; i++)
            {
                if (b[i] == "")
                {
                    for (var k = 0; k < 6; k++)
                    {
                        a[k] = "";
                    }
                    break;
                }

                for (var w = 0; w < 6; w++)
                {
                    a[w] = b[w];
                }
            }

            return a;
        }

        public bool CheckValidating(string p1, string p2, string p3, string p4, string p5, string p6)
        {
            var result = true;
            if (p1 == "")
            {
                result = false;
            }
            else if(p2 == "")
            {
                result = false;
            }
            else if (p3 == "")
            {
                result = false;
            }
            else if(p4 == "")
            {
                result = false;
            }
            else if (p5 == "")
            {
                result = false;
            }
            else if (p6 == "")
            {
                result = false;
            }

            return result;
        }

        public string ComboValidating(string p1)
        {
            var message = "";
            if (p1 == "")
            {
                message = "Enter type violation";
            }
            else
            {
                message = "Error";
            }

            return message;
        }
    }
}
