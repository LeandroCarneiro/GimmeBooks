import * as GETNewsAnalitics from '../requests/GETNewsAnalitics.request';

describe ('GET Tweets by Keyword', () => {
    const payload = 'World';

    it('Get tweets', () => {
        GETNewsAnalitics.getNewsAnalitics(payload).then((res) => {
            cy.log(res.body);
            cy.log(res.status);
            cy.log(res.statusText);
            cy.log(res.body);

            expect(res.status).to.be.eq(200);
            expect(res.body).to.be.not.null;
        });
    })
});