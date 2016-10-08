/**
 * 
 */

/**
 * @author Danny
 *
 */
public class BlackVoteState implements VoteState {
	@Override
	public void Vote(String user, String voteItem, VoteManager vManager){
		System.out.println("恶意刷票，你已经被拉近黑名单，禁止登陆！\n");
	}
}
