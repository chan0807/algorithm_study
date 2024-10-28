package chapter1;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;
import java.util.Queue;

public class Solution2 {
    public int[] solution(int[] progresses, int[] speeds) {
        
        List<Integer> list = new ArrayList<>();
        Queue<Integer> que  = new LinkedList<Integer>();
        
        for(int i=0; i <progresses.length; i++ ) {
            
            if((100-progresses[i])% speeds[i] == 0) { //당일배포
                que.offer((100-progresses[i])/speeds[i]);
                
            }else {
                que.offer((100-progresses[i])/speeds[i]+1); // 다음날 배포 
            }
        }
        
        int x = que.poll(); //첫번쨰 작업 배포일수 초기화
        int count = 1; // 같은날 배포할수 있는 작업일수
        
        while(!que.isEmpty()) {
            if(x >= que.peek()) {
                count++;
                que.remove();
            }else {
                list.add(count);
                x = que.poll(); //새로 배포 기준 갱신
                count = 1;
            }
        }
       
        
        return list.stream().mapToInt(i -> i).toArray();
    }
    
    
}
