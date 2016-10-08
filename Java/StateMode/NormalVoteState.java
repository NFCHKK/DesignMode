/**
 * 
 */

/**
 * @author Danny
 *
 */
public class NormalVoteState implements VoteState {
	@Override
	public void Vote(String user, String VoteItem, VoteManager vManager){
		vManager.GetMapVote().put(user, VoteItem);
		System.out.println("¹§Ï²Í¶Æ±³É¹¦\n");
	}

}
