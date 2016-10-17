using System;
using System.Collections.Generic;

namespace Specification {

    public class Program {

        public static void Main(string[] args) {
            var mobiles = new List<Mobile>() {
                new Mobile(MobileBrand.Apple, MobileType.Smart),
                new Mobile(MobileBrand.Samsung, MobileType.Smart),
                new Mobile(MobileBrand.Samsung, MobileType.Basic)
            };

            var smartSpecification = new ExpressionSpecification<Mobile>(mobile => mobile.Type == MobileType.Smart);
            var appleSpecification = new ExpressionSpecification<Mobile>(mobile => mobile.Brand = MobileBrand.Apple);
            // find all smart mobiles;
            var smartMobiles = mobiles.FindAll(mobile => smartSpecification.IsSatisfiedBy(mobile));
            // find all apple smart mobiles;
            var andSpecification = new AndSpecification<Mobile>(smartSpecification, appleSpecification);
            var appleSmartMobiles = mobiles.FindAll(mobile => andSpecification.IsSatisfiedBy(mobile));

            Console.WriteLine("Hello World!");
            
            Console.ReadKey();
        }

    }

    class Mobile {

        public MobileBrand Brand { get; }
        public MobileType Type { get; }

        public Mobile(MobileBrand brand, MobileType type) {
            Brand = brand;
            Type = type;
        }
    }

    enum MobileBrand {
        Samsung,
        Apple
    }

    enum MobileType {
        Smart, Basic
    }
}
