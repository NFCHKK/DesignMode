/**
 * 
 */

/**
 * @author Danny
 *
 */
public class SpiteVoteState implements VoteState {
	@Override
	public void Vote(String user, String voteItem, VoteManager vManager){
		String str = vManager.GetMapVote().get(user);
		if(str != null){
			vManager.GetMapVote().remove(user);
		}
		System.out.println("����ˢƱ��Ϊ��ȡ��ͶƱ�ʸ�\n");
	}

}
