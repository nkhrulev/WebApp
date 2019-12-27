import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { SearchIP } from './components/SearchIP';
import { SearchCity } from './components/SearchCity';

export default class App extends Component {
    static displayName = App.name;

    render() {
        return (
            <Layout>
                <Route path='/ip' component={SearchIP} />
                <Route path='/city' component={SearchCity} />
            </Layout>
        );
    }
}
