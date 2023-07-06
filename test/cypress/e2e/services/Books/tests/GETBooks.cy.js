import { ECategoryType } from '../../ECategoryType';
import { bookSearchPayload } from '../payloads/bookSearch.payload';
import * as GETBooks from '../requests/GETBooks_Category.request';

describe ('GET Books by Description and Keyword', () => {
    const payload = new bookSearchPayload(ECategoryType.Home, 'boy');

    it('Get books', () => {
        GETBooks.getBookCategoryKeyword(payload).then((res) => {
            cy.log(res.body);
            cy.log(res.status);
            cy.log(res.statusText);
            cy.log(res.body);

            expect(res.status).to.be.eq(200);
            expect(res.body).to.be.not.null;
        });
    })
});