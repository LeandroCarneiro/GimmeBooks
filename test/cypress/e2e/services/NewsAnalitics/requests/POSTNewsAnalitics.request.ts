/// <reference types="cypress"/>

import { ECategoryType } from "../../ECategoryType";

function POSTNewsAnalitics(category: ECategoryType){
    return cy.request({
        method: 'POST',
        url: `NewsAnalitics`,
        body: {category: category},
        headers: { 'Accept-Language': 'en-us', },
        failOnStatusCode: false,
    });
}

export { POSTNewsAnalitics };