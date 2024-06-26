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

using System.Text.Json.Serialization;

namespace Org.Eclipse.TractusX.SsiCredentialIssuer.Portal.Service.Models;

public record MailData(
    [property: JsonPropertyName("requester")] Guid Requester,
    [property: JsonPropertyName("template")] string Template,
    [property: JsonPropertyName("mailParameters")] IEnumerable<MailParameter> MailParameters
);

public record MailParameter(
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("value")] string Value
);
