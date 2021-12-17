namespace Groophy.LangPackage
{
    public class lang
    {
        public System.Collections.Generic.Dictionary<string, string> Lang = new System.Collections.Generic.Dictionary<string, string>();

        public object this[string propertyName]
        {
            get { return Lang[propertyName]; }
            set { Lang[propertyName] = value.ToString(); }
        }

        /// <summary>
        /// Return first char 1=successful 0,error=return problem
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string ReadLang(string path)
        {
            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(path);
                string[] srf = sr.ReadToEnd().Split(new[] { "\r\n", "\r", "\n" }, System.StringSplitOptions.None); sr.Close();

                for (int i = 0; i < srf.Length; i++)
                {
                    string[] parts = srf[i].Split('=');
                    string name = parts[0];
                    string value = string.Empty;
                    bool com = false;
                    for (int i2 = 1; i2 < parts.Length; i2++)
                    {
                        if (parts[i2].Contains("/"))
                        {
                            char[] ca = parts[i2].ToCharArray();
                            for (int i3 = 0; i3 < ca.Length; i3++)
                            {
                                if (com)
                                {
                                    if (ca[i3] == '*')
                                    {
                                        if (ca[i3 + 1] == '/') com = false; i3++;
                                    }
                                }
                                else
                                {
                                    if (ca[i3] == '/')
                                    {
                                        if (ca[i3 + 1] == '*') com = true;
                                    }
                                    if (!com) value += ca[i3];
                                }
                            }
                        }
                        else
                        {
                            value += parts[i2];
                        }
                    }
                    Lang[name] = value;
                }
                return "1";
            }
            catch (System.Exception eps)
            {
                return "0," + eps.Message;
            }
        }
    }
}
