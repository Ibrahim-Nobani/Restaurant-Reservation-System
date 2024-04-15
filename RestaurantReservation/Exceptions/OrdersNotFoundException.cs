namespace RestaurantReservation.Exceptions
{
    [System.Serializable]
    public class OrdersNotFoundException : Exception
    {
        public OrdersNotFoundException() { }
        public OrdersNotFoundException(string message) : base(message) { }
        public OrdersNotFoundException(string message, Exception inner) : base(message, inner) { }
        protected OrdersNotFoundException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}