
/*
   ♥  'LibKieraX'  ♥

   A collection of simple yet quite usefull data structures.

   Licensed under MIT License.

   *  ♥ By Tahlia P. Evlyne ♥ *

*/

/* ♥♥ Data structure with 4 points. ♥♥ */

    /* Flagged as Serializable. */

[ System.Serializable ] public struct Kiera4F { // ♥


    /* ♥ Variable declarations. ♥ */

        // Integral-Numeric Types for 4 dimensions.
        public float x , y , z , w ;


    /* ♥ Constructors ♥ */

        // Main Constructor, for use when assigning values during construction.
        public Kiera4F ( float x , float y , float z , float w ) { // ♥

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

        // Checks for equality against other Kiera4F instances.
        public bool Equals ( Kiera4F other ) { // ♥

            // Return result by checking equity of all 4 dimensions.
            return x == other.x && y == other.y && z == other.z && w == other.w ;

        } // ♥

        // Checks for equality against object instances.
        public override bool Equals ( object obj ) { // ♥

            // Return result by checking equity via some spooky-oop.
            if ( ReferenceEquals ( null , obj ) ) return false ;
            return obj is Kiera4F other && Equals ( other ) ;

        } // ♥


    /* ♥ Hashing overrides ♥ */

        // GetHashCode override action.
        public override int GetHashCode ( ) { // ♥

            // You don't have to check this code. XD
            unchecked { // ♥

                // Calculate and return the HashCode.
                var hashCode = ( int ) x ;
                hashCode = ( hashCode * 397 ) ^ ( int ) y ;
                hashCode = ( hashCode * 397 ) ^ ( int ) z ;
                hashCode = ( hashCode * 397 ) ^ ( int ) w ;

                return hashCode ;

            } // ♥

        } // ♥


    /* ♥ Operator declarations. ♥ */

        // Equity-Operator.
        public static bool operator == ( Kiera4F left , Kiera4F right ) { // ♥

            // Return the result of an Equity-Check.
            return left.Equals ( right ) ;

        } // ♥

        // Inverse Equity-Operator.
        public static bool operator != ( Kiera4F left , Kiera4F right ) { // ♥

            // Return the inverse result of an Equity-Check.
            return ! left.Equals ( right ) ;

        } // ♥

} // ♥


/* ♥♥ Data structure with 3 points. ♥♥ */

    /* Flagged as Serializable. */

[ System.Serializable ] public struct Kiera3F { // ♥


    /* ♥ Variable declarations. ♥ */

        // Integral-Numeric Types for 3 dimensions.
        public float x , y , z ;


    /* ♥ Constructors ♥ */

        // Main Constructor, for use when assigning values during construction.
        public Kiera3F ( float x , float y , float z ) { // ♥

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

        // Checks for equality against other Kiera3F instances.
        public bool Equals ( Kiera3F other ) { // ♥

            // Return result by checking equity of all 4 dimensions.
            return x == other.x && y == other.y && z == other.z ;

        } // ♥

        // Checks for equality against object instances.
        public override bool Equals ( object obj ) { // ♥

            // Return result by checking equity via some spooky-oop.
            if ( ReferenceEquals ( null , obj ) ) return false ;
            return obj is Kiera3F other && Equals ( other ) ;

        } // ♥


    /* ♥ Hashing overrides ♥ */

        // GetHashCode override action.
        public override int GetHashCode ( ) { // ♥

            // You don't have to check this code. XD
            unchecked { // ♥

                // Calculate and return the HashCode.
                var hashCode = ( int ) x ;
                hashCode = ( hashCode * 397 ) ^ ( int ) y ;
                hashCode = ( hashCode * 397 ) ^ ( int ) z ;

                return hashCode ;

            } // ♥

        } // ♥


    /* ♥ Operator declarations. ♥ */

        // Equity-Operator.
        public static bool operator == ( Kiera3F left , Kiera3F right ) { // ♥

            // Return the result of an Equity-Check.
            return left.Equals ( right ) ;

        } // ♥

        // Inverse Equity-Operator.
        public static bool operator != ( Kiera3F left , Kiera3F right ) { // ♥

            // Return the inverse result of an Equity-Check.
            return ! left.Equals ( right ) ;

        } // ♥

} // ♥


/* ♥♥ Data structure with 2 points. ♥♥ */

    /* Flagged as Serializable. */

[ System.Serializable ] public struct Kiera2F { // ♥


    /* ♥ Variable declarations. ♥ */

        // Integral-Numeric Types for 2 dimensions.
        public float x , y ;


    /* ♥ Constructors ♥ */

        // Main Constructor, for use when assigning values during construction.
        public Kiera2F ( float x , float y ) { // ♥

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

        // Checks for equality against other Kiera2F instances.
        public bool Equals ( Kiera3F other ) { // ♥

            // Return result by checking equity of all 4 dimensions.
            return x == other.x && y == other.y ;

        } // ♥

        // Checks for equality against object instances.
        public override bool Equals ( object obj ) { // ♥

            // Return result by checking equity via some spooky-oop.
            if ( ReferenceEquals ( null , obj ) ) return false ;
            return obj is Kiera2F other && Equals ( other ) ;

        } // ♥


    /* ♥ Hashing overrides ♥ */

        // GetHashCode override action.
        public override int GetHashCode ( ) { // ♥

            // You don't have to check this code. XD
            unchecked { // ♥

                // Calculate and return the HashCode.
                var hashCode = ( int ) x ;
                hashCode = ( hashCode * 397 ) ^ ( int ) y ;

                return hashCode ;

            } // ♥

        } // ♥


    /* ♥ Operator declarations. ♥ */

        // Equity-Operator.
        public static bool operator == ( Kiera2F left , Kiera2F right ) { // ♥

            // Return the result of an Equity-Check.
            return left.Equals ( right ) ;

        } // ♥

        // Inverse Equity-Operator.
        public static bool operator != ( Kiera2F left , Kiera2F right ) { // ♥

            // Return the inverse result of an Equity-Check.
            return ! left.Equals ( right ) ;

        } // ♥

} // ♥
