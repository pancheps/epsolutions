

import java.util.ArrayList;
import java.util.List;


public class Euler46 {


    public static void main(String[] args) {

       for(int i = 2; i < 10000; i++) {
           boolean isPrime = isPrime(i);
           if(!isPrime&&i%2!=0) {//composite
               boolean test = testForAllSubPrimes(i);
               if(!test) {Util.print("Value does not conform: " + i);break;};
           }
       }
    }

    private static List<Integer> getPrimesLowerThan(final int i) {

          var primes = new ArrayList<Integer>();

          for(int j = 2; j < i; j++) {
              if(isPrime(j)) primes.add(j);
          }

          return primes;
      }
    private static boolean isPrime(final int j) {
        for(int i = 2; i < j/2; i++) {
            if(j % i == 0) return false;
        }
        return true;
    }

    private static boolean testForAllSubPrimes(final int i) {
        for(int prime: getPrimesLowerThan(i)) {
            for (int j = 1; j < i; j++)
                if (i == prime + 2 * j * j) return true;
        }
        return false;
    }

}
