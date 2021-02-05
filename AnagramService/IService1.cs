using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AnagramService
{
    // NOT: "IService1" arabirim adını kodda ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string Kontrol(string kelime1, string kelime2);
    }


    // Hizmet işlemlerine bileşik türler eklemek için, aşağıdaki örnekte gösterildiği şekilde bir veri sözleşmesi kullanın.
    // Projeye XSD dosyaları ekleyebilirsiniz. Projeyi yaptıktan sonra "AnagramService.ContractType" ad uzayını kullanarak orada tanımlı veri türlerini kullanabilirsiniz.
    
}
