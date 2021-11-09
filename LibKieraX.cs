
/*
*       'LibKieraX'
*
*   A collection of simple yet quite usefull data structures.
*
*       By Tahlia P. Evlyne ♥♥
*
*/


/* ♥♥ Data structure with 4 points. ♥♥ */
[ System.Serializable ] public struct Kiera4 {

    public int x , y , z , w ;

    public Kiera4 ( int x , int y , int z , int w ) {

        this.x = x ;
        this.y = y ;
        this.z = z ;
        this.w = w ;

    }

    public override string ToString ( ) {

        return x + ":" + y + ":" + z + ":" + w ;

    }

    public bool Equals ( Kiera4 other ) {

        return x == other.x && y == other.y && z == other.z && w == other.w ;

    }
    public override bool Equals ( object obj ) {

        if ( ReferenceEquals ( null , obj ) ) return false ;
        return obj is Kiera4 other && Equals ( other ) ;

    }
    public override int GetHashCode ( ) {

        unchecked {

            var hashCode = x ;

            hashCode = ( hashCode * 397 ) ^ y ;
            hashCode = ( hashCode * 397 ) ^ z ;
            hashCode = ( hashCode * 397 ) ^ w ;

            return hashCode ;

        }

    }
    public static bool operator == ( Kiera4 left , Kiera4 right ) {

        return left.Equals ( right ) ;

    }
    public static bool operator != ( Kiera4 left , Kiera4 right ) {

        return ! left.Equals ( right ) ;

    }

}

/* ♥♥ Data structure with 3 points. ♥♥ */
[ System.Serializable ] public struct Kiera3 {

    public int x , y , z ;

    public Kiera3 ( int x , int y , int z ) {

        this.x = x ;
        this.y = y ;
        this.z = z ;

    }

    public override string ToString ( ) {

        return x + ":" + y + ":" + z ;

    }

    public bool Equals ( Kiera3 other ) {

        return x == other.x && y == other.y && z == other.z ;

    }
    public override bool Equals ( object obj ) {

        if ( ReferenceEquals( null , obj ) ) return false ;
        return obj is Kiera3 other && Equals ( other ) ;

    }
    public override int GetHashCode ( ) {

        unchecked {

            var hashCode = x ;

            hashCode = ( hashCode * 397 ) ^ y ;
            hashCode = ( hashCode * 397 ) ^ z ;

            return hashCode ;

        }

    }
    public static bool operator == ( Kiera3 left , Kiera3 right ) {

        return left.Equals( right ) ;

    }
    public static bool operator != ( Kiera3 left , Kiera3 right ) {

        return ! left.Equals( right ) ;

    }

}

/* ♥♥ Data structure with 2 points. ♥♥ */
[ System.Serializable ] public struct Kiera2 {

    public int x , y ;

    public Kiera2 ( int x , int y ) {

        this.x = x ;
        this.y = y ;

    }

    public override string ToString ( ) {

        return x + ":" + y ;

    }

    public bool Equals ( Kiera2 other ) {

        return x == other.x && y == other.y ;

    }
    public override bool Equals ( object obj ) {

        if ( ReferenceEquals( null , obj ) ) return false ;
        return obj is Kiera2 other && Equals ( other ) ;

    }
    public override int GetHashCode ( ) {

        unchecked {

            var hashCode = x ;

            hashCode = ( hashCode * 397 ) ^ y ;

            return hashCode ;

        }

    }
    public static bool operator == ( Kiera2 left , Kiera2 right ) {

        return left.Equals ( right ) ;

    }
    public static bool operator != ( Kiera2 left , Kiera2 right ) {

        return ! left.Equals ( right ) ;

    }

}
