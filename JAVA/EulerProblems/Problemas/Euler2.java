
import java.text.DecimalFormat;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.List;
import java.util.Set;
import java.util.stream.IntStream;

public class Euler2 {

  public static void main(String[] args) {

      System.out.println(Arrays.stream(getFibosLowerThan(4000000)).filter(integer -> integer%2==0).mapToInt(Integer::intValue).sum());

  }

  private static Integer[] getFibosLowerThan(final int maxValue) {
      List<Integer> a = new ArrayList<>(Arrays.asList(1,2));
      for(int i=2;;i++){
          a.add(a.get(i-1)+a.get(i-2));
          if(a.get(i)>maxValue) break;
      }
      return a.toArray(new Integer[0]);
  }

}


