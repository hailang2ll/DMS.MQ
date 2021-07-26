using DMS.Common.Extensions;
using DMS.RabbitMQ.Attributes;

namespace DMS.RabbitMQ.Utils
{
    public class AttributeUtil
    {
        private static RabbitMQAttribute _rabbitMQAttribute;
        public static RabbitMQAttribute GetRabbitMQAttribute<T>()
        {
            if (_rabbitMQAttribute.IsNullOrEmpty())
            {
                var typeOfT = typeof(T);
                _rabbitMQAttribute = typeOfT.GetCustomAttribute<RabbitMQAttribute>();
            }

            return _rabbitMQAttribute;
        }
    }
}
