namespace _12.Parse_URL
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string urlInput = Console.ReadLine();
            Uri uri = new Uri(urlInput);
            string protocol = uri.Scheme;
            string server = uri.Host;
            string resource = uri.AbsolutePath;

            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}"
                , protocol, server, resource);
        }
    }
}
