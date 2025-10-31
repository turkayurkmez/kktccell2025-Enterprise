using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled
{
    public class Oyuncu
    {
        public void Giy(IKiyafet kiyafet)
        {

        }
    }

    public interface IKiyafet { }

    public abstract class Pantolon : IKiyafet { }


    public abstract class UstGiyim { }
    public class Kazak : UstGiyim { }
    public class KirmiziKazak : Kazak
    {

    }
}
