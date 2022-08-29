using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superhero_class
{
    internal class superhelt
    {
        private string secret_idensiti;
        private string superpowers;
        private string kostume;
        private string reason_to_fight_krime;
        private string morale_kodeks;
        private string archenemy;
        private string truma_privat_life;

        public string Secret_idensiti { get => secret_idensiti; set => secret_idensiti = value; }
        public string Superpowers { get => superpowers; set => superpowers = value; }
        public string Kostume { get => kostume; set => kostume = value; }
        public string Reason_to_fight_krime { get => reason_to_fight_krime; set => reason_to_fight_krime = value; }
        public string Morale_kodeks { get => morale_kodeks; set => morale_kodeks = value; }
        public string Archenemy { get => archenemy; set => archenemy = value; }
        public string Truma_privat_life { get => truma_privat_life; set => truma_privat_life = value; }

        //under here is all the metohd that make up the super hero
        public void secrt_idensiti()

        {
            Console.WriteLine("han hemlige idensitet er light guy");
        }
        public void superpower()
        {
            Console.WriteLine("lavet af lys, kan bevæge sig med lyset hastihed,han kan forkusere lyset, bruge det til at angribe");
        }
        public void kostum()
        {
            Console.WriteLine("grøn komodo og en grøn hat det deger hans ansigt");
        }
        public void reason_for_fig()
        {
            Console.WriteLine("grunden til han slåes er fordi han kæreste er í rollestole og han vil beskyte hende");
        }
        public void morale_kodax()
        {
            Console.WriteLine("aldrig slå en kvinde");
        }
        public void enmey()
        {
            Console.WriteLine("han fjene er cat women");
        }
        public void tramua()
        {
            Console.WriteLine("i hans hverdag kæmper han med at lade være med at slå hovedt ind i alle ting ");
        }
    }
}
