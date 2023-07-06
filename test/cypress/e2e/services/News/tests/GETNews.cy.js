import { ECategoryType } from '../../ECategoryType';
import * as GETNews from '../requests/GETNews_Category.request';

describe ('GET News by Description', () => {
    const payload = ECategoryType.Science;

    it('Get news', () => {
        GETNews.getNewsCategory(payload).then((res) => {
            cy.log(res.body);
            cy.log(res.status);
            cy.log(res.statusText);
            cy.log(res.body);

            expect(res.status).to.be.eq(200);
            expect(res.body).to.be.not.null;
        });
    })
});