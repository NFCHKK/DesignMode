/**
 * 
 */

/**
 * @author Danny
 *
 */
public class RepeatVoteState implements VoteState{
	@Override
	public void Vote(String user, String VoteItem, VoteManager vManager){
		System.out.println("请不要重复投票\n");
	}

}
