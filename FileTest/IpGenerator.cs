using System;

namespace FileTest
{
	struct IpAddress
    {
		public byte a;
		public byte b;
		public byte c;
		public byte d;

		public string ToString()
        {
			return String.Format("{0}.{1}.{2}.{3}", this.a, this.b, this.c, this.d);
        }
    }
	internal class IpGenerator
	{
		Random random;

		public IpGenerator()
        {
			this.random = new Random();
        }

		public IpAddress PublicIp()
		{
			IpAddress ip = new IpAddress();

			ip.a = (byte) this.random.Next(1, 254);
			ip.b = (byte) this.random.Next(0, 254);
			ip.c = (byte) this.random.Next(0, 254);
			ip.d = (byte) this.random.Next(1, 254);

			return ip;
		}

		public IpAddress PrivateIp()
		{
			IpAddress ip = new IpAddress();

			if (this.random.NextInt64() % 3 == 0)
			{
				ip.a = 192;
				ip.b = 168;
			}
			else
            {
				ip.a = 172;
				ip.b = 17;
			}

			ip.c = (byte)this.random.Next(0, 254);
			ip.d = (byte)this.random.Next(1, 254);

			return ip;
		}

		public IpAddress AnyIp()
        {
			return this.random.NextInt64() % 9 == 0 ? this.PrivateIp() : this.PublicIp();
		}
	}
}
