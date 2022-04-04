public class Euler44 {


    public static void main(String[] args) {

        outer:
        for(int j=1; j<10000; j++)
            for(int k=1; k < 10000; k++) {
                int pj = getPentagonal(j);
                int pk = getPentagonal(k);
                System.out.printf("Trying %d : %d / %d : %d %n", j,pj, k,pk);
                boolean isSumPentagonal = isPentagonal(pj+pk); if(!isSumPentagonal) continue;
                boolean isSubPentagonal = isPentagonal(Math.abs(pj-pk)); if(!isSubPentagonal) continue;

                System.out.printf("Min Pent %d + %d = %d diff %d %n", j, k, getPentagonal(j)+getPentagonal(k),Math.abs(getPentagonal(j)-getPentagonal(k)));
                break outer;
            }
    }

    private static int getPentagonal(final int n) {
        return n*(3*n-1)/2;
    }


    private static boolean isPentagonal(int number) {
        double penTest = (Math.sqrt(1 + 24 * number) + 1.0) / 6.0;
        return penTest == ((int)penTest);
    }
}
