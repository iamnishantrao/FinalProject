import { RepoModel } from '../models/repo.model';

export interface StarrepoModel {
    starredRepositories: RepoModel;
    userId: number
}