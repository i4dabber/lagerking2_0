using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lagerking.Mediator
{
    public static class EventRaiser
    {
        public static void Raise(this EventHandler handler, object sender)
        {
            //En måde at invoke delagete på
            handler?.Invoke(sender, EventArgs.Empty);
        }

        public static void Raise<T>(this EventHandler<EventArgs<T>> handler, object sender, T value)
        {
            if (handler != null)
            {
                handler(sender, new EventArgs<T>(value));
            }
        }

        public static void Raise<T>(this EventHandler<T> handler, object sender, T value) where T : EventArgs
        {
            if (handler != null)
            {
                handler(sender, value);
            }
        }

        public static void Raise<T>(this EventHandler<EventArgs<T>> handler, object sender, EventArgs<T> value)
        {
            if (handler != null)
            {
                handler(sender, value);
            }
        }
    }
}
