﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KurlarService
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
	[ServiceContract]
	public interface IKurService
    {

		[OperationContract]
		List<string> ParaBirimileriGetir();

		[OperationContract]
		List<double> KurlariGetir(string kurTipi);

		// TODO: Add your service operations here
	}

}
