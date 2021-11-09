
/*
   ♥  'LibKieraX'  ♥

   A collection of simple yet quite usefull data structures.

   Licensed under MIT License.

   *  ♥ By Tahlia P. Evlyne ♥ *

*/

/* ♥♥ Data structure with 4 points. ♥♥ */

    /* Flagged as Serializable. */

[ System.Serializable ] public struct Kiera4 { // ♥


    /* ♥ Variable declarations. ♥ */

        // Integral-Numeric Types for 4 dimensions.
        public int x , y , z , w ;


    /* ♥ Constructors ♥ */

        // Main Constructor, for use when assigning values during construction.
        public Kiera4 ( int x , int y , int z , int w ) { // ♥

            // Asigns local numeric values.
            this.x = x ; this.y = y ; this.z = z ; this.w = w ;

        } // ♥


    /* ♥ Override Methods ♥ */

        // ToString action override.
        public override string ToString ( ) { // ♥

            // Returns numeric values combined in string form.
            return x + ":" + y + ":" + z + ":" + w ;

        } // ♥


    /* ♥ Equality Members ♥ */

        // Checks for equality against other Kiera4 instances.
        public bool Equals ( Kiera4 other ) { // ♥

            // Return result by checking equity of all 4 dimensions.
            return x == other.x && y == other.y && z == other.z && w == other.w ;

        } // ♥

        // Checks for equality against object instances.
        public override bool Equals ( object obj ) { // ♥

            // Return result by checking equity via some spooky-oop.
            if ( ReferenceEquals ( null , obj ) ) return false ;
            return obj is Kiera4 other && Equals ( other ) ;

        } // ♥


    /* ♥ Hashing overrides ♥ */

        // GetHashCode override action.
        public override int GetHashCode ( ) { // ♥

            // You don't have to check this code. XD
            unchecked { // ♥

                // Calculate and return the HashCode.
                var hashCode = x ;
                hashCode = ( hashCode * 397 ) ^ y ;
                hashCode = ( hashCode * 397 ) ^ z ;
                hashCode = ( hashCode * 397 ) ^ w ;

                return hashCode ;

            } // ♥

        } // ♥


    /* ♥ Operator declarations. ♥ */

        // Equity-Operator.
        public static bool operator == ( Kiera4 left , Kiera4 right ) { // ♥

            // Return the result of an Equity-Check.
            return left.Equals ( right ) ;

        } // ♥

        // Inverse Equity-Operator.
        public static bool operator != ( Kiera4 left , Kiera4 right ) { // ♥

            // Return the inverse result of an Equity-Check.
            return ! left.Equals ( right ) ;

        } // ♥

} // ♥


/* ♥♥ Data structure with 3 points. ♥♥ */

    /* Flagged as Serializable. */

[ System.Serializable ] public struct Kiera3 { // ♥


    /* ♥ Variable declarations. ♥ */

        // Integral-Numeric Types for 3 dimensions.
        public int x , y , z ;


    /* ♥ Constructors ♥ */

        // Main Constructor, for use when assigning values during construction.
        public Kiera3 ( int x , int y , int z ) { // ♥

            // Asigns local numeric values.
            this.x = x ; this.y = y ; this.z = z ;

        } // ♥


    /* ♥ Override Methods ♥ */

        // ToString action override.
        public override string ToString ( ) { // ♥

            // Returns numeric values combined in string form.
            return x + ":" + y + ":" + z ;

        } // ♥


    /* ♥ Equality Members ♥ */

        // Checks for equality against other Kiera3 instances.
        public bool Equals ( Kiera3 other ) { // ♥

            // Return result by checking equity of all 4 dimensions.
            return x == other.x && y == other.y && z == other.z ;

        } // ♥

        // Checks for equality against object instances.
        public override bool Equals ( object obj ) { // ♥

            // Return result by checking equity via some spooky-oop.
            if ( ReferenceEquals ( null , obj ) ) return false ;
            return obj is Kiera3 other && Equals ( other ) ;

        } // ♥


    /* ♥ Hashing overrides ♥ */

        // GetHashCode override action.
        public override int GetHashCode ( ) { // ♥

            // You don't have to check this code. XD
            unchecked { // ♥

                // Calculate and return the HashCode.
                var hashCode = x ;
                hashCode = ( hashCode * 397 ) ^ y ;
                hashCode = ( hashCode * 397 ) ^ z ;

                return hashCode ;

            } // ♥

        } // ♥


    /* ♥ Operator declarations. ♥ */

        // Equity-Operator.
        public static bool operator == ( Kiera3 left , Kiera3 right ) { // ♥

            // Return the result of an Equity-Check.
            return left.Equals ( right ) ;

        } // ♥

        // Inverse Equity-Operator.
        public static bool operator != ( Kiera3 left , Kiera3 right ) { // ♥

            // Return the inverse result of an Equity-Check.
            return ! left.Equals ( right ) ;

        } // ♥

} // ♥


/* ♥♥ Data structure with 2 points. ♥♥ */

    /* Flagged as Serializable. */

[ System.Serializable ] public struct Kiera2 { // ♥


    /* ♥ Variable declarations. ♥ */

        // Integral-Numeric Types for 2 dimensions.
        public int x , y ;


    /* ♥ Constructors ♥ */

        // Main Constructor, for use when assigning values during construction.
        public Kiera2 ( int x , int y ) { // ♥

            // Asigns local numeric values.
            this.x = x ; this.y = y ;

        } // ♥


    /* ♥ Override Methods ♥ */

        // ToString action override.
        public override string ToString ( ) { // ♥

            // Returns numeric values combined in string form.
            return x + ":" + y ;

        } // ♥


    /* ♥ Equality Members ♥ */

        // Checks for equality against other Kiera2 instances.
        public bool Equals ( Kiera3 other ) { // ♥

            // Return result by checking equity of all 4 dimensions.
            return x == other.x && y == other.y ;

        } // ♥

        // Checks for equality against object instances.
        public override bool Equals ( object obj ) { // ♥

            // Return result by checking equity via some spooky-oop.
            if ( ReferenceEquals ( null , obj ) ) return false ;
            return obj is Kiera2 other && Equals ( other ) ;

        } // ♥


    /* ♥ Hashing overrides ♥ */

        // GetHashCode override action.
        public override int GetHashCode ( ) { // ♥

            // You don't have to check this code. XD
            unchecked { // ♥

                // Calculate and return the HashCode.
                var hashCode = x ;
                hashCode = ( hashCode * 397 ) ^ y ;

                return hashCode ;

            } // ♥

        } // ♥


    /* ♥ Operator declarations. ♥ */

        // Equity-Operator.
        public static bool operator == ( Kiera2 left , Kiera2 right ) { // ♥

            // Return the result of an Equity-Check.
            return left.Equals ( right ) ;

        } // ♥

        // Inverse Equity-Operator.
        public static bool operator != ( Kiera2 left , Kiera2 right ) { // ♥

            // Return the inverse result of an Equity-Check.
            return ! left.Equals ( right ) ;

        } // ♥

} // ♥

