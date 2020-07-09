using Repository;
using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 55555;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);
            //string con = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            IUserRepository ar = new UserRepository("farmacie2");
            IOrderRepository or = new OrderRepository("farmacie2");
            IDrugRepository dr = new DrugRepository("farmacie2");
            ItemRepository ir = new ItemRepository("farmacie2");
            var serviceImpl = new ServerImplementation(ar, or, dr, ir);

            ar.add("admin", "admin", Model.Status.Admin, 1);
            ar.add("user5", "user5", Model.Status.Pharmacist, 1);
            foreach (var el in serviceImpl.filterdrugs("Somn"))
                Console.WriteLine(el.Description);
            //var server = new ChatServerImpl();
            RemotingServices.Marshal(serviceImpl, "Client");
            //RemotingConfiguration.RegisterWellKnownServiceType(typeof(ChatServerImpl), "Chat",
            //    WellKnownObjectMode.Singleton);

            // the server will keep running until keypress.
            Console.WriteLine("Server started ...");
            Console.WriteLine("Press <enter> to exit...");
            Console.ReadLine();
        }
    }
}
