import java.util.List;
import java.util.ArrayList;

public final class SampleJava{
    public static void main(String args[]){
      RefTypeTest sample = new RefTypeTest();

      sample.intValue = 999;
      copyTest(sample);
      System.out.println("copyTest() sample.intValue = " + sample.intValue);

      sample.intValue = 999;
      copyTest2(sample);
      System.out.println("copyTest() sample.intValue = " + sample.intValue);
    }

}

