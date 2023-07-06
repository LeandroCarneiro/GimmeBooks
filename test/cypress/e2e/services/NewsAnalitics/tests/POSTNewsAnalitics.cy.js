import { ECategoryType } from '../../ECategoryType';
import * as POSTNewsAnalitics from '../requests/POSTNewsAnalitics.request';

describe ('POST Anailitics by Keyword', () => {
    const payload = ECategoryType.Home;

    it('POST News Anailitics', () => {
        POSTNewsAnalitics.POSTNewsAnalitics(payload).then((res) => {
            cy.log(res.body);
            cy.log(res.status);
            cy.log(res.statusText);
            cy.log(res.body);

            expect(res.status).to.be.eq(200);
            expect(res.body).to.be.not.null;
        });
    })
});