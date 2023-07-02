/// <reference types="cypress"/>

import { bookSearchPayload } from "../payloads/bookSearch.payload";

function getBookCategoryKeyword(request: bookSearchPayload){
    return cy.request({
        method: 'GET',
        url: `Book?category=${request.category}&keywords=${request.keyword}`,
        headers: { 'Accept-Language': 'en-us', },
        failOnStatusCode: false,
    });
}

export { getBookCategoryKeyword };