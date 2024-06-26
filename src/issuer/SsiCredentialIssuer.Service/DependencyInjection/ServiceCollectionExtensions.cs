/********************************************************************************
 * Copyright (c) 2024 Contributors to the Eclipse Foundation
 *
 * See the NOTICE file(s) distributed with this work for additional
 * information regarding copyright ownership.
 *
 * This program and the accompanying materials are made available under the
 * terms of the Apache License, Version 2.0 which is available at
 * https://www.apache.org/licenses/LICENSE-2.0.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 *
 * SPDX-License-Identifier: Apache-2.0
 ********************************************************************************/

using Org.Eclipse.TractusX.SsiCredentialIssuer.Service.BusinessLogic;

namespace Org.Eclipse.TractusX.SsiCredentialIssuer.Service.DependencyInjection;

public static class ServiceCollectionExtensions
{
    internal static IServiceCollection AddServices(this IServiceCollection services, IConfiguration config) =>
        services
            .AddIssuerService(config.GetSection("Credential"))
            .AddRevocationService()
            .AddCredentialService();

    private static IServiceCollection AddIssuerService(this IServiceCollection services, IConfigurationSection section) =>
        services
            .ConfigureCredentialSettings(section)
            .AddTransient<IIssuerBusinessLogic, IssuerBusinessLogic>();

    private static IServiceCollection AddRevocationService(this IServiceCollection services) =>
        services
            .AddTransient<IRevocationBusinessLogic, RevocationBusinessLogic>();

    private static IServiceCollection AddCredentialService(this IServiceCollection services) =>
        services
            .AddTransient<ICredentialBusinessLogic, CredentialBusinessLogic>();
}
