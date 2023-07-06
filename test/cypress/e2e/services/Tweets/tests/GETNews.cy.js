import * as GETtweet from '../requests/GETTweet_Keyword.request';

describe ('GET Tweets by Keyword', () => {
    const payload = 'World';

    it('Get tweets', () => {
        GETtweet.getTweetsKeyword(payload).then((res) => {
            cy.log(res.body);
            cy.log(res.status);
            cy.log(res.statusText);
            cy.log(res.body);

            expect(res.status).to.be.eq(200);
            expect(res.body).to.be.not.null;
        });
    })
});