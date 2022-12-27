namespace GraphQlClientGenerator;

public static class IntrospectionQuery
{
    public const string Text =
        @"query IntrospectionQuery {
    __schema {
      queryType { name }
      mutationType { name }
      subscriptionType { name }
      types {
        ...FullType
      }
      directives {
        name
        description
        locations
        args {
          ...InputValue
        }
      }
      appliedDirectives{
        ...AppliedDirective
      }
    }
  }

  fragment FullType on __Type {
    kind
    name
    appliedDirectives{
      ...AppliedDirective
    }
    description
    appliedDirectives{
      ...AppliedDirective
    }
    fields(includeDeprecated: true) {
      name
      description
      args {
        ...InputValue
      }
      type {
        ...TypeRef
      }
      isDeprecated
      deprecationReason
    }
    inputFields {
      ...InputValue
    }
    interfaces {
      ...TypeRef
    }
    enumValues(includeDeprecated: true) {
      name
      description
      isDeprecated
      deprecationReason
    }
    possibleTypes {
      ...TypeRef
    }
  }

  fragment InputValue on __InputValue {
    name
    description
    type { ...TypeRef }
    defaultValue
    appliedDirectives{
      ...AppliedDirective
    }
  }

  fragment TypeRef on __Type {
    kind
    name
    appliedDirectives{
      ...AppliedDirective
    }
    ofType {
      kind
      name
      ofType {
        kind
        name
        ofType {
          kind
          name
            ofType {
            kind
            name
            ofType {
              kind
              name
              ofType {
                kind
                name
              }
            }
          }
        }
      }
    }
  }

  fragment AppliedDirective on __AppliedDirective {
    name
    args {
      name
      value
    }
  }";
}