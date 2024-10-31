package chapter1;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Solution3 {
	 public int[] solution(int []arr) {
		 
		 	List<Integer> list = new ArrayList<>();
		 	
		 	for(int i=0; i < arr.length-1; i++) {
		 		if(arr[i] != arr[i+1]) {
		 			list.add(arr[i]);
		 		}
		 	}
		 	
		 	//마지막 추가해줌
		 	
		 	list.add(arr[arr.length-1]);
		 
		 
	       

	        return list.stream().mapToInt(i -> i).toArray();
	    }
	 
	 public static void main(String[] args) {
	        Solution3 solution = new Solution3();
	        
	        int[] arr = {1,1,3,3,0,1,1};
	        int[] arr2 = {4,4,4,3,3};
	        
	        int[] result = solution.solution(arr2);
	        System.out.println(Arrays.toString(result)); //[1,3,0,1]
	    }
}
