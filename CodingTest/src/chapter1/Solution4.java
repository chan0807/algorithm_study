package chapter1;

import java.util.Arrays;
import java.util.Stack;

public class Solution4 {
	 boolean solution(String s) {
	       
	        
	        if(s.charAt(0) == ')') return false;
	        
	        Stack<Character> stack = new Stack<>();
	        
	        for(int i=0; i< s.length(); i++) {
	        	if(s.charAt(i) == '(') {
	        		stack.push(s.charAt(i));
	        	}else {
	        		
	        		if(stack.isEmpty()) {
	        			return false;
	        		}
	        		stack.pop();
	        	}
	        }
	           
	        return stack.isEmpty();
	    }
	 
	 
	 public static void main(String[] args) {
	        Solution4 solution = new Solution4();
	        
	        String s= "()()";
	        boolean result= solution.solution(s);
	        System.out.println(result); 
	    }
}
