using deneme.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme.Providers
{
    public class FirebaseManager
    {
        // Burada real time database ile ayarlamalarını yapıyoruz
        FirebaseClient firebase = new FirebaseClient("https://sampletez.firebaseio.com/");
        /* Childi persoons olan tüm databasei alıyorum. Eğer farklı bir tabloyu çekmek istiyorusam onu da childin içinde belirtmemiz gerekiyor.
         Sanırım son konuştuğumuzda sadece belirli idye sahip olanları çekmek istiyordun. Onun için 2 farklı yönetim var.
         1- Tüm listeyi çekebilirsin. Tüm listeyi çektikten sonra foreach ile listenin içerisini önip if ile id eşitse ile yakalarsın
         2- Bu yöntemi aşağıda yorum satırı ile fonksyion oluşturuyorum
             */
        public async Task<List<SampleFirebaseModel>> GetAllPersons()
        {

            return (await firebase
              .Child("Persons")
              .OnceAsync<SampleFirebaseModel>()).Select(item => new SampleFirebaseModel
              {
                  Name = item.Object.Name,
                  PersonId = item.Object.PersonId
              }).ToList();
        }
        // Bu da 2. yöntem direk veritabanından çağırısın. Böylece mobil makineyide yormazsın.
        public async Task<SampleFirebaseModel> GetSelectedPerson(int personId)
        {
            var allPerson = (await firebase.Child("Persons").OnceAsync<SampleFirebaseModel>());
            var selectedPerson = allPerson.Where(a => a.Object.PersonId == personId).FirstOrDefault();
            return selectedPerson.Object;
        }

        // Burada da tablona bir column ekleyebilirsin. BUrada dikkat etmen gereken şey aslında modelin tablonun columnları olacak. Buna göre ayarlamalısın
        /* ZAten tez yazıyorsun biliyorsun o yüzden uzatmama gerek yok 
           Child içerisine yazdığın string öenmli tablonun isimleri olacak. Ona göre mantıklı isimler vermelisin
             */
        public async Task AddPerson(int personId, string name)
        {
            await firebase
              .Child("Persons")
              .PostAsync(new SampleFirebaseModel() { Name = name, PersonId = personId });
        }

        /* 
          Örnek kodlara bakmak istersen buradan ulaşabilirsin.
          https://github.com/elmarkos23/XF.FirebaseDB/blob/da424e4298c78ee9da0629db19f1378ce9280f14/XF.FirebaseDB/Firebase/PersonaFB.cs
            Yine takıldığın yerler olursa haberleşiriz. Kolay gelsin.
          */
    }

}
