using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SUPER
{
	public sealed class AssemblyType
	{
		private DataContractJsonSerializer dashboard;

		private object dashboard;

		public AssemblyType(object object_0)
		{
			dashboard = object_0;
			Type type = dashboard.GetType();
			this.dashboard = new DataContractJsonSerializer(type);
			if (!MainLoad(type))
				throw new Exception($"the object {dashboard} isn't a serializable");
		}

		public static bool MainLoad(Type type_0)
		{
			return type_0.IsSerializable || type_0.IsDefined(typeof(DataContractAttribute), true);
		}

		public object MainLoad(string string_0)
		{
			using (MemoryStream stream = new MemoryStream(Encoding.Default.GetBytes(string_0)))
				return ((XmlObjectSerializer)this.dashboard).ReadObject((Stream)stream);
		}

		public T MainLoad<T>(string string_0)
		{
			return (T)MainLoad(string_0);
		}
	}
}
